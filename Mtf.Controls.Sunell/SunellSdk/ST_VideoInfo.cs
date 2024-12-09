using System.Runtime.InteropServices;

namespace Mtf.Controls.Sunell.SunellSdk
{
    /// <summary>
    /// Represents video information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct ST_VideoInfo
    {
        /// <summary>
        /// Video bitrate.
        /// </summary>
        public int BitRate;

        /// <summary>
        /// Video resolution width.
        /// </summary>
        public int Width;

        /// <summary>
        /// Video resolution height.
        /// </summary>
        public int Height;

        // Add other properties with appropriate summaries.
    }
}
