using System.Runtime.InteropServices;

namespace Mtf.Controls.Sunell.SunellSdk
{
    /// <summary>
    /// Represents extended device information, including network and router mapping details.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct ST_DeviceInfoExNetSdk
    {
        /// <summary>
        /// The network address of the device.
        /// </summary>
        public ST_InetAddr stInetAddr;

        /// <summary>
        /// Represents the network address, including IP address and port information.
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct ST_InetAddr
        {
            /// <summary>
            /// The IP address in dot-decimal notation.
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 49)]
            public string szHostIP;

            /// <summary>
            /// The port number.
            /// </summary>
            public ushort nPORT;

            /// <summary>
            /// The IP protocol version: 1 for IPv4, 2 for IPv6.
            /// </summary>
            public int nIPProtoVer;
        }

        /// <summary>
        /// The user ID used for device authentication.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szUserID;

        /// <summary>
        /// The password used for device authentication.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string szPassword;

        /// <summary>
        /// The unique identifier of the device.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szDeviceID;

        /// <summary>
        /// The name of the device.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szDeviceName;

        /// <summary>
        /// The type of the device, represented as a long value.
        /// </summary>
        public long nDeviceType;

        /// <summary>
        /// Indicates whether router mapping is enabled.
        /// </summary>
        public bool m_bRouterMappingEnableFlag;

        /// <summary>
        /// The router address for device mapping.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 49)]
        public string m_szRouterAddr;

        /// <summary>
        /// The router mapping control port number.
        /// </summary>
        public ushort m_nRouterMappingControlPort;

        /// <summary>
        /// The router mapping TCP audio/video port number.
        /// </summary>
        public ushort m_nRouterMappingTCPAVPort;

        /// <summary>
        /// The router mapping RTSP port number.
        /// </summary>
        public ushort m_nRouterMappingRTSPPort;

        /// <summary>
        /// The router mapping RTP port number.
        /// </summary>
        public ushort m_nRouterMappingRTPPort;

        /// <summary>
        /// The router mapping RTCP port number.
        /// </summary>
        public ushort m_nRouterMappingRTCPPort;
    }
}
