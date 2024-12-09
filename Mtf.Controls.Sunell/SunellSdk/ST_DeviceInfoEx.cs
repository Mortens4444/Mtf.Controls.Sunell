using System.Runtime.InteropServices;

namespace Mtf.Controls.Sunell.SunellSdk
{
    /// <summary>
    /// Represents extended device information, including routing details.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct ST_DeviceInfoEx
    {
        /// <summary>
        /// Network address of the device.
        /// </summary>
        public ST_InetAddr InetAddr;

        /// <summary>
        /// User ID for logging into the device.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string UserID;

        /// <summary>
        /// Password for logging into the device.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string Password;

        /// <summary>
        /// Device ID.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceID;

        /// <summary>
        /// Device name.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;

        /// <summary>
        /// Device type identifier.
        /// </summary>
        public int DeviceType;

        /// <summary>
        /// Flag indicating if router mapping is enabled.
        /// </summary>
        public string RouterMappingEnableFlag;

        /// <summary>
        /// Router address (IP or domain name).
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 49)]
        public string RouterAddress;

        /// <summary>
        /// Router mapping control port.
        /// </summary>
        public int RouterMappingControlPort;

        /// <summary>
        /// Router mapping TCP audio-video port.
        /// </summary>
        public int RouterMappingTCPAVPort;

        /// <summary>
        /// Router mapping RTSP port.
        /// </summary>
        public int RouterMappingRTSPPort;

        /// <summary>
        /// Router mapping RTP port.
        /// </summary>
        public int RouterMappingRTPPort;

        /// <summary>
        /// Router mapping RTCP port.
        /// </summary>
        public int RouterMappingRTCPPort;
    }
}
