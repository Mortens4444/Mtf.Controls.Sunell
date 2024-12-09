using System.Runtime.InteropServices;

namespace Mtf.Controls.Sunell.SunellSdk
{
    /// <summary>
    /// Represents basic information about a camera.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct ST_CameraInfoParam
    {
        /// <summary>
        /// The unique ID of the camera.
        /// </summary>
        public int nCameraId;

        /// <summary>
        /// The name of the camera.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szCameraName;

        /// <summary>
        /// The model of the camera.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szCameraModel;

        /// <summary>
        /// The video system standard used by the camera.
        /// </summary>
        public int nVideoSystem;
    }
}
