using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Mtf.Controls.Sunell.SunellSdk
{
    public static class NvdcNetSDK
    {
        private const string DllName = "NvdcNetSDK.dll";

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_Init();

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_UnInit();

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void SDK_GetVersion(IntPtr p_nVersion);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_Login(ref IntPtr p_lHandle, ref ST_DeviceInfoExNetSdk p_stDeviceInfo, int p_nTimeOut);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern long SDK_Logout(IntPtr p_lHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_SetNotifyWindow(IntPtr p_hHandle, IntPtr p_hDisplayWnd, uint p_nMessage, IntPtr p_pParam);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_Open(IntPtr p_lHandle, ST_LiveVideoPreviewInfo p_stLiveVideoPreviewInfo, ref IntPtr p_plRemoteLivePlayerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_SetRealtimeMode(IntPtr p_plRemoteLivePlayerHandle, RealtimeMode realtimeMode);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_Play(IntPtr lRemoteLivePlayerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_Pause(IntPtr lRemoteLivePlayerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_GetPlayStatus(IntPtr lRemoteLivePlayerHandle, out int nPlayStatus);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_Refresh(IntPtr lRemoteLivePlayerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_SetDrawVideoMode(IntPtr lRemoteLivePlayerHandle, int nDrawMode);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_MakeKeyFrame(IntPtr lRemoteLivePlayerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_GetVideoEffect(IntPtr lRemoteLivePlayerHandle, out int nBrightness, out int nContrast, out int nHue, out int nSaturation);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_SetVideoEffect(IntPtr lRemoteLivePlayerHandle, int nBrightness, int nContrast, int nHue, int nSaturation);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_GetCurrentStreamId(IntPtr lRemoteLivePlayerHandle, out uint nCurrentStreamId);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_GetCurrentFrameRate(IntPtr lRemoteLivePlayerHandle, out uint nFrameRate);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_GetCurrentBitRate(IntPtr lRemoteLivePlayerHandle, out uint nBitRate);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_GetPictureSize(IntPtr lRemoteLivePlayerHandle, out int nWidth, out int nHeight);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_SnapShot(IntPtr lRemoteLivePlayerHandle, string pszFileName, string szFormat);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_SetRecordFile(IntPtr lRemoteLivePlayerHandle, string pszFileName, int nFileFormat);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_StartRecord(IntPtr lRemoteLivePlayerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_StopRecord(IntPtr lRemoteLivePlayerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_GetRecordStatus(IntPtr lRemoteLivePlayerHandle, out int nPlayStatus);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_PlaySound(IntPtr lRemoteLivePlayerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_StopSound(IntPtr lRemoteLivePlayerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_SetVolume(IntPtr lRemoteLivePlayerHandle, int volume);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_RemoteLivePlayer_GetVolume(IntPtr lRemoteLivePlayerHandle, out int volume);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_VideoController_Open(IntPtr handle, uint cameraId, uint streamId, int streamFormat, out IntPtr videoControllerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_VideoController_Close(IntPtr videoControllerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_VideoController_StartVideo(IntPtr videoControllerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SDK_VideoController_StopVideo(IntPtr videoControllerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_RemoteLivePlayer_IsOnSound(IntPtr lRemoteLivePlayerHandle, out bool bOnSound);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_RemoteLivePlayer_ZoomInVideoEx(IntPtr lRemoteLivePlayerHandle, uint x, uint y, uint width, uint height);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_RemoteLivePlayer_ZoomInVideo(IntPtr lRemoteLivePlayerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_RemoteLivePlayer_ZoomOutVideo(IntPtr lRemoteLivePlayerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_RemoteLivePlayer_RestoreVideo(IntPtr lRemoteLivePlayerHandle);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int SDK_VideoController_SetAVDataCallback(IntPtr lVideoControllerHandle, AVDataCallback fAVDataCallback, IntPtr pAVDataUserData);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int SDK_VideoController_SetMessageCallback(IntPtr lVideoControllerHandle, MessageCallback fMessageCallback, IntPtr pMessageUserData);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_VideoController_Ctrl(IntPtr lVideoControllerHandle, int nCtrl);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int SDK_RecordQuery_Open(IntPtr lHandle, ref ST_QueryInfo stQueryInfo, out IntPtr plRecordQueryHandle, out int pnResultNum);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int SDK_RecordQuery_Query(IntPtr lRecordQueryHandle, int nIndex, ref ST_RecordTimeSegment pstRecordTimeSegment);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_RecordQuery_Close(IntPtr lRecordQueryHandle);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int SDK_RecordDateController_Open(IntPtr lHandle, long nChannelID, ref ST_RecordTimeSegment stRecordTimeSegment, out IntPtr plRecordDateControllerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_RecordDateController_Close(IntPtr lRecordDateControllerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_RecordDateController_Read(IntPtr lRecordDateControllerHandle, byte[] pszBuf, uint nBufSize);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_RecordDateController_Read(IntPtr lRecordDateControllerHandle, ref ST_AVFrameData stAVFrameData);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_RecordDateController_Ctrl(IntPtr lRecordDateControllerHandle, int nCtrl, long nParam);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int SDK_DeviceController_RecordCtrl(long deviceControllerHandle, ST_RecordInfo recordInfo, int control);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_PTZController_OpenPTZ(IntPtr handle, int cameraID, out long ptzControllerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_PTZController_ClosePTZ(IntPtr ptzControllerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_PTZController_Ctrl(IntPtr ptzControllerHandle, int control, int id, IntPtr buffer);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CMS_Init(out IntPtr handle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CMS_UnInit(ref IntPtr handle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CMS_AlarmCenter_AddDeviceInfo(ref IntPtr handle, ST_DeviceInfoExNetSdk deviceInfo);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CMS_AlarmCenter_RemoveDeviceInfo(ref IntPtr handle, ST_InetAddr inetAddr);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CMS_AlarmCenter_RemoveAll(ref IntPtr handle);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int CMS_AlarmCenter_SetAlarmCallback(ref IntPtr handle, AlarmCallBack alarmCallback, IntPtr alarmCallbackData);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CMS_AlarmCenter_Open(ref IntPtr handle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CMS_AlarmCenter_Close(ref IntPtr handle);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int SDK_LogInfoQuery_Open(IntPtr handle, ST_QueryInfo queryInfo, out long logInfoQueryHandle, out int resultNum);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int SDK_LogInfoQuery_Query(IntPtr logInfoQueryHandle, int index, out ST_LogInfo logInfo);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_LogInfoQuery_Close(IntPtr logInfoQueryHandle);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int SDK_AlarmInfoQuery_Open(IntPtr handle, ST_QueryInfo queryInfo, out long alarmInfoQueryHandle, out int resultNum);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int SDK_AlarmInfoQuery_Query(IntPtr alarmInfoQueryHandle, int index, out ST_AlarmInfoRecordSet alarmInfoRecordSet);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_AlarmInfoQuery_Close(IntPtr alarmInfoQueryHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_DeviceController_Restart(IntPtr deviceControllerHandle);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int SDK_DeviceController_Reset(IntPtr deviceControllerHandle, ref ST_ResetType resetType);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_IPCDeviceController_Open(IntPtr handle, out IntPtr ipcDeviceControllerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_IPCDeviceController_Close(IntPtr ipcDeviceControllerHandle);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int SDK_IPCDeviceController_GetROIInfoParam(IntPtr ipcDeviceControllerHandle, int channelID, int streamId, out ST_ROIInfoParamList roiInfoParamList);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int SDK_IPCDeviceController_SetROIInfoParam(IntPtr ipcDeviceControllerHandle, int channelID, int streamId, ref ST_ROIInfoParamList roiInfoParamList);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_IPCDeviceController_GetIntelligenceAnalysisParam(IntPtr ipcDeviceControllerHandle, int control, IntPtr buffer, IntPtr buffer2 = default);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_IPCDeviceController_SetIntelligenceAnalysisParam(IntPtr ipcDeviceControllerHandle, int control, IntPtr buffer);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_DeviceController_BlindCtrl(IntPtr deviceControllerHandle, int control, int channelID, int areaParamID, IntPtr buffer);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_DeviceController_Open(IntPtr handle, out IntPtr deviceControllerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_DeviceController_Close(IntPtr deviceControllerHandle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_DeviceController_SetConfig(IntPtr deviceControllerHandle, long channelID, long commandID, IntPtr inputBuffer, long inputBufferSize);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_DeviceController_GetConfig(IntPtr handle, long channelID, long commandID, IntPtr outputBuffer, long outputBufferSize, out long dataLength);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_RemoteSensorController_Open(IntPtr handle, long channelID, out long remoteSensorController);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_RemoteSensorController_Close(long remoteSensorController);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_RemoteSensorController_SetConfig(long remoteSensorController, int key, int value);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SDK_RemoteSensorController_GetConfig(IntPtr remoteSensorController, int key, out int value);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int CMS_DeviceDiscovery_Init(out IntPtr handle, ST_InetAddr multicastAddr, ST_DeviceTypeList deviceTypeList, bool sameDeviceFilterFlag = true, int searchInterval = 10);

        //[DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern int CMS_DeviceDiscovery_SetDeviceCallback(IntPtr handle, DeviceCallback findDeviceCallback, IntPtr findDeviceCallbackData);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CMS_DeviceDiscovery_Start(IntPtr handle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int CMS_DeviceDiscovery_Stop(IntPtr handle);

        [DllImport(DllName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        private static extern void SDK_FormatMessage(int p_nErrorCode, [MarshalAs(UnmanagedType.LPStr)] StringBuilder p_pszErrorMessage, int p_nMessageBufLen);

        public static string GetErrorMessage(int p_nErrorCode)
        {
            var stringBuilder = new StringBuilder(512);
            SDK_FormatMessage(p_nErrorCode, stringBuilder, stringBuilder.Capacity);
            return stringBuilder.ToString();
        }
    }
}
