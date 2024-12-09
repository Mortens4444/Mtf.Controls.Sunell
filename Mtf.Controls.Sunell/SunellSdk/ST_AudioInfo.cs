using System.Runtime.InteropServices;

namespace Mtf.Controls.Sunell.SunellSdk
{
    /// <summary>
    /// Represents audio information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct ST_AudioInfo
    {
        /// <summary>
        /// Format tag for the audio.
        /// </summary>
        public int FormatTag;

        /// <summary>
        /// Number of audio channels.
        /// </summary>
        public int Channels;

        /// <summary>
        /// Number of samples per second.
        /// </summary>
        public int SamplesPerSecond;

        /// <summary>
        /// Average bytes per second for the audio stream.
        /// </summary>
        public int AvgBytesPerSecond;

        /// <summary>
        /// Size of each audio block.
        /// </summary>
        public int BlockAlign;

        /// <summary>
        /// Bits per sample for the audio stream.
        /// </summary>
        public int BitsPerSample;

        /// <summary>
        /// Additional data size for audio encoding.
        /// </summary>
        public int AdditionalDataSize;
    }
}
