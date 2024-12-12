using Mtf.Controls.Sunell.CustomEventArgs;
using Mtf.Controls.Sunell.SunellSdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Mtf.Controls.Sunell
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(SunellVideoWindow), "Resources.VideoSource.png")]
    public class SunellVideoWindow : PictureBox
    {
        private IntPtr nvdHandle = IntPtr.Zero;

        private const int WM_USER = 0x400;
        private const int WM_LIVEPLAY_MESSAGE = WM_USER + 1000;

        public delegate void VideoSignalChangedEventHandler(object sender, VideoSignalChangedEventArgs e);

        private SunellVersion sunellVersion = SunellVersion.SN_IPR56_41APDN_M;
        private readonly Dictionary<SunellVersion, Func<int, string>> messageFormatters = new Dictionary<SunellVersion, Func<int, string>>
            {
                { SunellVersion.SN_IPR56_41APDN_M, NvdcDll.GetErrorMessage },
                { SunellVersion.SN_IPR57_41APDN_Z, NvdcNetSDK.GetErrorMessage }
            };

        public event VideoSignalChangedEventHandler VideoSignalChanged;

        public SunellVideoWindow()
        {
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();
            BackgroundImage = Properties.Resources.NoSignal;
            BackgroundImageLayout = ImageLayout.Stretch;
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Disconnect();
            }
            base.Dispose(disposing);
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Text to be displayed on the control.")]
        public string OverlayText { get; set; } = String.Empty;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Font type of the text to be displayed on the control.")]
        public Font OverlayFont { get; set; } = new Font("Arial", 32, FontStyle.Bold);

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Color of the text to be displayed on the control.")]
        public Brush OverlayBrush { get; set; } = Brushes.White;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Location of the text to be displayed on the control.")]
        public Point OverlayLocation { get; set; } = new Point(10, 10);

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsConnected { get; set; }

        public void Connect(string cameraIp = "192.168.0.120", ushort cameraPort = 30001, string username = "admin", string password = "admin")
        {
            var deviceInfo = new ST_DeviceInfo
            {
                UserID = username,
                Password = password,
                InetAddr = new ST_InetAddr
                {
                    HostIP = cameraIp,
                    Port = cameraPort,
                    IPProtocolVersion = 1
                }
            };

            const int transferProtocol = 2;
            var returnCode = NvdcDll.Remote_Nvd_Init(ref nvdHandle, ref deviceInfo, transferProtocol);
            CheckForError(returnCode);

            if (NvdcDll.NvdSdk_Is_Handle_Valid(nvdHandle))
            {
                _ = NvdcDll.Remote_LivePlayer2_SetAutoConnectFlag(nvdHandle, true);
                _ = NvdcDll.Remote_LivePlayer2_SetDefaultStreamId(nvdHandle, 1);

                returnCode = NvdcDll.Remote_LivePlayer2_Open(nvdHandle, 1);
                CheckForError(returnCode);

                returnCode = NvdcDll.Remote_LivePlayer2_SetNotifyWindow(nvdHandle, Handle, WM_LIVEPLAY_MESSAGE, IntPtr.Zero);
                CheckForError(returnCode);

                returnCode = NvdcDll.Remote_LivePlayer2_SetVideoWindow(nvdHandle, Handle, 0, 0, Width, Height);
                CheckForError(returnCode);

                // Connect with old camera
                returnCode = NvdcDll.Remote_LivePlayer2_Play(nvdHandle);

                if (returnCode == -503)
                {
                    Disconnect();
                    nvdHandle = IntPtr.Zero;

                    // Connect with new camera
                    sunellVersion = SunellVersion.SN_IPR57_41APDN_Z;

                    returnCode = NvdcNetSDK.SDK_Init();
                    CheckForError(returnCode);

                    var deviceInfoEx = new ST_DeviceInfoExNetSdk
                    {
                        szUserID = deviceInfo.UserID,
                        szPassword = deviceInfo.Password,
                        szDeviceName = deviceInfo.DeviceName,
                        szDeviceID = deviceInfo.DeviceID,
                        stInetAddr = new ST_DeviceInfoExNetSdk.ST_InetAddr
                        {
                            nIPProtoVer = deviceInfo.InetAddr.IPProtocolVersion,
                            nPORT = deviceInfo.InetAddr.Port,
                            szHostIP = deviceInfo.InetAddr.HostIP
                        },
                        nDeviceType = deviceInfo.DeviceType,
                        m_bRouterMappingEnableFlag = false
                    };

                    returnCode = NvdcNetSDK.SDK_Login(ref nvdHandle, ref deviceInfoEx, 10000);
                    CheckForError(returnCode);

                    returnCode = NvdcNetSDK.SDK_RemoteLivePlayer_SetNotifyWindow(nvdHandle, Handle, WM_LIVEPLAY_MESSAGE, IntPtr.Zero);
                    CheckForError(returnCode);

                    var stLiveViewPreviewInfo = new ST_LiveVideoPreviewInfo
                    {
                        bAutoConnectFlag = true,
                        bStretchMode = true,
                        nCameraId = 1,
                        nDisplayWnd = 0,
                        nStreamId = 1,
                        nTransferProtocol = 2
                    };

                    var livePlayerHandle = new IntPtr();
                    returnCode = NvdcNetSDK.SDK_RemoteLivePlayer_Open(nvdHandle, stLiveViewPreviewInfo, ref livePlayerHandle);
                    CheckForError(returnCode);

                    returnCode = NvdcNetSDK.SDK_RemoteLivePlayer_SetRealtimeMode(livePlayerHandle, RealtimeMode.RealTime);
                    CheckForError(returnCode);

                    returnCode = NvdcNetSDK.SDK_RemoteLivePlayer_Play(nvdHandle); //livePlayerHandle);
                }

                CheckForError(returnCode);
                IsConnected = true;
            }
            else
            {
                throw new InvalidOperationException("The handle is not valid.");
            }
            RefreshImage();
        }

        public void Disconnect()
        {
            _ = NvdcDll.Remote_LivePlayer2_Close(nvdHandle);
            _ = NvdcDll.Remote_Nvd_UnInit(nvdHandle);
            IsConnected = false;
            //Invoke((Action)(() => { Invalidate(); }));
        }

        public int PTZ_Open(int cameraId)
        {
            return NvdcDll.Remote_PTZEx_Open(nvdHandle, cameraId);
        }

        public int PTZ_Close()
        {
            return NvdcDll.Remote_PTZEx_Close(nvdHandle);
        }

        public int PTZ_Stop()
        {
            return NvdcDll.Remote_PTZEx_Stop(nvdHandle);
        }

        public int PTZ_RotateUp(int speed)
        {
            return NvdcDll.Remote_PTZEx_RotateUp(nvdHandle, speed);
        }

        public int PTZ_RotateDown(int speed)
        {
            return NvdcDll.Remote_PTZEx_RotateDown(nvdHandle, speed);
        }

        public int PTZ_RotateRight(int speed)
        {
            return NvdcDll.Remote_PTZEx_RotateRight(nvdHandle, speed);
        }

        public int PTZ_RotateLeft(int speed)
        {
            return NvdcDll.Remote_PTZEx_RotateLeft(nvdHandle, speed);
        }

        private void RefreshImage()
        {
            _ = NvdcDll.Remote_LivePlayer2_SetVideoWindow(nvdHandle, Handle, 0, 0, Width, Height);
            Invoke((Action)(() => { Invalidate(); }));
        }

        protected override void OnResize(EventArgs e)
        {
            RefreshImage();
            base.OnResize(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            RefreshImage();
            base.OnSizeChanged(e);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_LIVEPLAY_MESSAGE:
                    switch ((SunellEventID)m.WParam.ToInt32())
                    {
                        case SunellEventID.EVENTID_CREATE_VIDEO_SESSION_SUCCESS:
                            {
                                BackgroundImage = null;
                                VideoSignalChanged?.Invoke(this, new VideoSignalChangedEventArgs(true));

                                RefreshImage();
                                break;
                            }
                        case SunellEventID.EVENTID_LOGIN_USERNAME_WRONG:
                        case SunellEventID.EVENTID_LOGIN_PASSWORD_WRONG:
                        case SunellEventID.EVENTID_CREATE_VIDEO_SESSION_FAILED:
                        case SunellEventID.EVENTID_RECEIVE_VIDEO_ERROR:
                        case SunellEventID.EVENTID_DEVICE_NOT_SUPPORT_VIDEO:
                            {
                                //BackgroundImage = NoSignalImage;
                                VideoSignalChanged?.Invoke(this, new VideoSignalChangedEventArgs(false));
                                break;
                            }
                        default:
                            base.WndProc(ref m);
                            break;
                    }
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!String.IsNullOrEmpty(OverlayText))
            {
                var graphics = e.Graphics;
                {
                    //_ = graphics.MeasureString(OverlayText, OverlayFont);
                    graphics.DrawString(OverlayText, OverlayFont, OverlayBrush, OverlayLocation);
                }
            }
        }

        private void CheckForError(int errorCode, [CallerMemberName] string callerFunction = "", [CallerFilePath] string callerFile = "", [CallerLineNumber] int callerLine = 0)
        {
            if (errorCode != 0)
            {
                throw new AggregateException($"ErrorCode: {errorCode}, {callerFunction} in {callerFile}, line {callerLine}", new InvalidOperationException(messageFormatters[sunellVersion](errorCode)));
            }
        }
    }
}
