﻿using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Mtf.Controls.Sunell.IPR66.SunellSdk
{
    public static class NvdcDll
    {
        [DllImport("NvdcDll.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int Remote_Nvd_Init(ref int p_handle, ref ST_DeviceInfo st_DeviceInfo, int p_nTransferProtocol);

        [DllImport("NvdcDll.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int Remote_Nvd_Init(ref IntPtr p_handle, ref ST_DeviceInfo st_DeviceInfo, int p_nTransferProtocol);

        [DllImport("NvdcDll.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int Remote_Camera2_SetDefaultStreamId(int p_hHandle, int p_nStreamId);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_Camera2_Open(int p_hHandle, int p_nCameraID);

        [DllImport("NvdcDll.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int Remote_Camera2_Read(int p_hHandle, ref ST_AVFrameData stAVFrameData);

        [DllImport("NvdcDll.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int Remote_Nvd_UnInit(int p_hHandle);

        [DllImport("NvdcDll.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int Remote_Nvd_UnInit(IntPtr p_hHandle);

        [DllImport("NvdcDll.dll")]
        public static extern bool NvdSdk_Is_Handle_Valid(int p_hHandle);

        [DllImport("NvdcDll.dll")]
        public static extern bool NvdSdk_Is_Handle_Valid(IntPtr p_hHandle);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_Camera2_GetCurrentStreamId(int p_hHandle, ref int p_nStreamId);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_LivePlayer2_Open(int p_hHandle, int p_nCameraID);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_LivePlayer2_Open(IntPtr p_hHandle, int p_nCameraID);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_LivePlayer2_Close(int p_hHandle);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_LivePlayer2_Close(IntPtr p_hHandle);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_LivePlayer2_Play(int p_hHandle);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_LivePlayer2_Play(IntPtr p_hHandle);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_LivePlayer2_SetVideoWindow(int p_hHandle, int p_hDisplayWnd, int x, int y, int width, int height);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_LivePlayer2_GetCurrentBitRate(IntPtr p_hHandle3, ref ulong nBitRate);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_LivePlayer2_SetVideoWindow(IntPtr p_hHandle, IntPtr p_hDisplayWnd, int x, int y, int width, int height);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_LivePlayer2_SetNotifyWindow(IntPtr p_hHandle, IntPtr p_hDisplayWnd, uint p_nMessage, IntPtr p_pParam);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_LivePlayer2_SetAutoConnectFlag(int p_hHandle, bool bTrue);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_LivePlayer2_SetAutoConnectFlag(IntPtr p_hHandle, bool bTrue);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_LivePlayer2_SetDefaultStreamId(int p_hHandle, int p_nStreamId);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_LivePlayer2_SetDefaultStreamId(IntPtr p_hHandle, int p_nStreamId);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_PTZEx_Open(int p_hHandle, int p_nCameraID);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_PTZEx_Close(int p_hHandle);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_PTZEx_Stop(int p_hHandle);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_PTZEx_RotateUp(int p_hHandle, int p_nSpeedValue);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_PTZEx_RotateDown(int p_hHandle, int p_nSpeedValue);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_PTZEx_RotateLeft(int p_hHandle, int p_nSpeedValue);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_PTZEx_RotateRight(int p_hHandle, int p_nSpeedValue);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_PTZEx_Open(IntPtr p_hHandle, int p_nCameraID);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_PTZEx_Close(IntPtr p_hHandle);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_PTZEx_Stop(IntPtr p_hHandle);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_PTZEx_RotateUp(IntPtr p_hHandle, int p_nSpeedValue);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_PTZEx_RotateDown(IntPtr p_hHandle, int p_nSpeedValue);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_PTZEx_RotateLeft(IntPtr p_hHandle, int p_nSpeedValue);

        [DllImport("NvdcDll.dll")]
        public static extern int Remote_PTZEx_RotateRight(IntPtr p_hHandle, int p_nSpeedValue);

        [DllImport("NvdcDll.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        private static extern void Remote_Nvd_formatMessage(int p_nErrorCode, [MarshalAs(UnmanagedType.LPStr)] StringBuilder p_pszErrorMessage, int p_nMessageBufLen);

        public static string GetErrorMessage(int p_nErrorCode)
        {
            var stringBuilder = new StringBuilder(512);
            Remote_Nvd_formatMessage(p_nErrorCode, stringBuilder, stringBuilder.Capacity);
            return stringBuilder.ToString();
        }
    }

}
