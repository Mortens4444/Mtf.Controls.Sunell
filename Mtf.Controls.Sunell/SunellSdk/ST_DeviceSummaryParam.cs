using System.Runtime.InteropServices;

namespace Mtf.Controls.Sunell.SunellSdk
{
    /// <summary>
    /// Represents summary information about a device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct ST_DeviceSummaryParam
    {
        /// <summary>
        /// The name of the device.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szDeviceName;

        /// <summary>
        /// The unique identifier of the device.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szDeviceId;

        /// <summary>
        /// The manufacturer's ID for the device model.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szManufacturerId;

        /// <summary>
        /// The name of the manufacturer.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szManufacturerName;

        /// <summary>
        /// The product model of the device.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szProductModel;

        /// <summary>
        /// Description of the product.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szProductDescription;

        /// <summary>
        /// The hardware model of the device.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szHardwareModel;

        /// <summary>
        /// Description of the hardware.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szHardwareDescription;

        /// <summary>
        /// The MAC address of the device.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szMACAddress;

        /// <summary>
        /// The barcode of the device.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szBarCode;

        /// <summary>
        /// The production time of the device.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szProductionTime;

        /// <summary>
        /// The type of device.
        /// </summary>
        public int nDeviceType;

        /// <summary>
        /// The video encoding frame mode.
        /// </summary>
        public int nVideoSystem;

        /// <summary>
        /// The number of cameras associated with the device.
        /// </summary>
        public int nCameraNum;

        /// <summary>
        /// The number of alarm inputs.
        /// </summary>
        public int nAlarmInNum;

        /// <summary>
        /// The number of alarm outputs.
        /// </summary>
        public int nAlarmOutNum;

        /// <summary>
        /// The hardware version information.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szHardwareVer;

        /// <summary>
        /// The software version information.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szSoftwareVer;

        /// <summary>
        /// The number of RS485 serial ports.
        /// </summary>
        public int nRS485Num;

        /// <summary>
        /// The number of RS232 serial ports.
        /// </summary>
        public int nRS232Num;
    }
}
