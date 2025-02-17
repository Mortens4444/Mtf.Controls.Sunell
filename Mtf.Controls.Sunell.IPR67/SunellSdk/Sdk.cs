﻿using System;
using System.Runtime.InteropServices;

namespace Mtf.Controls.Sunell.IPR67.SunellSdk
{
    public static class Sdk
    {
        private const string SdkDll = "Sdk_C_Sharp_Lib.dll";

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate void SDK_MICROPHONE_CB(UInt32 handle, IntPtr p_data, ref Int32 data_len, IntPtr p_obj);

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate void SDK_FACEBASE_CB(UInt32 handle, IntPtr p_data, ref Int32 data_len, ref IntPtr p_result, IntPtr p_obj);

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate void SDK_INTERCOM_DB_CB(UInt32 db, IntPtr p_obj);

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate void SDK_FACE_CB(UInt32 handle, Int32 pic_type, IntPtr p_data, ref Int32 data_len, ref IntPtr p_result, IntPtr p_obj);

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate void SDK_DETECT_CB(UInt32 handle, Int32 stream_id, ref IntPtr p_result, IntPtr p_data, IntPtr p_obj);

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate void SDK_STREAM_DATE_LEN(UInt32 len);

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate void SDK_PLAY_TIME_CB(UInt32 handle, Int32 stream_id, IntPtr p_obj, ref byte p_time);

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate void SDK_CONNECT_CB(UInt32 handle, IntPtr p_obj);

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate void SDK_DISCONN_CB(UInt32 handle, IntPtr p_obj, UInt32 type);

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate void SDK_STREAM_CB(UInt32 handle, Int32 stream_id, IntPtr p_data, IntPtr p_obj);

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate void SDK_ALARM_CB(UInt32 handle, ref IntPtr p_data, IntPtr p_ob);

        [UnmanagedFunctionPointerAttribute(CallingConvention.Cdecl)]
        public delegate void SDK_WIFI_CB(UInt32 handle, ref byte p_data, IntPtr p_ob);

        public delegate void SDK_MUTI_COMPARE_CB(UInt32 handle, IntPtr p_pic1, Int32 data_len1, IntPtr p_pic2, Int32 data_len2, IntPtr p_result, IntPtr p_obj);

        public delegate void SDK_NVR_SNAP_MSG_CB(UInt32 handle, IntPtr p_data, IntPtr p_ob);

        public delegate void SDK_MUTI_OBJ_DOWNLOAD_CB(UInt32 handle, IntPtr p_pic1, Int32 data_len1, ref byte key1, IntPtr p_pic2, Int32 data_len2, ref byte key2, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 sdk_dev_conn([MarshalAs(UnmanagedType.LPStr)] string p_ip, UInt16 port, [MarshalAs(UnmanagedType.LPStr)] string p_user, [MarshalAs(UnmanagedType.LPStr)] string p_passwd, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_DISCONN_CB disconn_cb_func, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_live_start(UInt32 handle, Int32 chn, StreamType stream_type, IntPtr p_wnd, bool is_hw_dec, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_PLAY_TIME_CB play_cb, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_live_stop(UInt32 handle, Int32 stream_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_chg_stream(UInt32 handle, Int32 stream_id, Int32 stream_type);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_pb_start(UInt32 handle, Int32 chn, Int32 new_stream_type, [MarshalAs(UnmanagedType.LPStr)] string s_time, IntPtr p_wnd, bool is_hw_dec, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_PLAY_TIME_CB play_cb, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_pb_seek(UInt32 handle, Int32 stream_id, [MarshalAs(UnmanagedType.LPStr)] string time);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_pb_pause(UInt32 handle, Int32 stream_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_pb_resume(UInt32 handle, Int32 stream_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_pb_stop(UInt32 handle, Int32 stream_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_set_pb_speed(UInt32 handle, Int32 stream_id, Int32 rate);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_rec_start(UInt32 handle, Int32 stream_id, [MarshalAs(UnmanagedType.LPStr)] string p_path, [MarshalAs(UnmanagedType.LPStr)] string p_filename);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_rec_start_width_time(UInt32 handle, Int32 stream_id, [MarshalAs(UnmanagedType.LPStr)] string s_time, [MarshalAs(UnmanagedType.LPStr)] string e_time, [MarshalAs(UnmanagedType.LPStr)] string p_path, [MarshalAs(UnmanagedType.LPStr)] string p_filename);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_rec_stop(UInt32 handle, Int32 stream_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_rec_percent(UInt32 handle, Int32 stream_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_rec_download_start(UInt32 handle, Int32 chn, Int32 stream_type, [MarshalAs(UnmanagedType.LPStr)] string s_time, [MarshalAs(UnmanagedType.LPStr)] string e_time, [MarshalAs(UnmanagedType.LPStr)] string p_path, [MarshalAs(UnmanagedType.LPStr)] string p_filename);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_rec_download_stop(UInt32 handle, Int32 stream_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_capture(UInt32 handle, Int32 stream_id, [MarshalAs(UnmanagedType.LPStr)] string p_path);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_audio_start(UInt32 handle, Int32 stream_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_audio_stop(UInt32 handle, Int32 stream_id);
        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_talk_start(UInt32 handle, Int32 chn, SDK_INTERCOM_DB_CB intercom_db_cb, IntPtr obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_md_talk_stop(UInt32 handle, Int32 chn);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_view_zoomin(UInt32 handle, Int32 stream_id, Int32 x, Int32 y, Int32 w, Int32 h);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_view_zoominout_centern(UInt32 handle, Int32 stream_id, Int32 scale);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_init([MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void sdk_dev_quit();

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void sdk_free_result(IntPtr p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 sdk_dev_conn_ssl([MarshalAs(UnmanagedType.LPStr)] string p_ip, UInt16 port, [MarshalAs(UnmanagedType.LPStr)] string p_user, [MarshalAs(UnmanagedType.LPStr)] string p_passwd, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_DISCONN_CB disconn_cb_func, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_con_sta(UInt32 handle);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_conn_async([MarshalAs(UnmanagedType.LPStr)] string p_ip, UInt16 port, [MarshalAs(UnmanagedType.LPStr)] string p_user, [MarshalAs(UnmanagedType.LPStr)] string p_passwd, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_DISCONN_CB disconn_cb, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_CONNECT_CB conn_cb, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void sdk_dev_conn_close(UInt32 handle);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_addr_req(UInt32 handle, Int32 ipprotover, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_live_start(UInt32 handle, Int32 chn, Int32 stream_type, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_STREAM_CB stream_cb, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_live_stop(UInt32 handle, Int32 stream_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_chg_stream(UInt32 handle, Int32 stream_id, Int32 new_stream_type);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_video_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_video_param(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_video_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_video_control(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_audio_para);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_audio_start(UInt32 handle, Int32 stream_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_audio_stop(UInt32 handle, Int32 stream_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_open_snap(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_snap_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_close_snap(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_snap_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_snap_data(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_snap_param, ref byte p_buf, ref int len);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_snap_picture(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_snap_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_open_picture_edit(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_snap_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_pb_date_list(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string s_date, [MarshalAs(UnmanagedType.LPStr)] string e_date, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_pb_chns_in_date(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_date, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_pb_get_rec_list(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_date, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_pb_start(UInt32 handle, Int32 chn, Int32 stream_type, [MarshalAs(UnmanagedType.LPStr)] string s_time, [MarshalAs(UnmanagedType.LPStr)] string e_time, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_STREAM_CB stream_cb, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_pb_seek(UInt32 handle, Int32 stream_id, [MarshalAs(UnmanagedType.LPStr)] string time);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_pb_pause(UInt32 handle, Int32 stream_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_pb_resume(UInt32 handle, Int32 stream_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_pb_stop(UInt32 handle, Int32 stream_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_pb_video_param(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_pb_video_speed(UInt32 handle, Int32 stream_id, Int32 rate);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_open_rec([MarshalAs(UnmanagedType.LPStr)] string p_path, [MarshalAs(UnmanagedType.LPStr)] string p_filename);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_record(Int32 record_id, ref tagAVFrameData p_frame);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_stop_rec(Int32 record_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_start_alarm(UInt32 handle, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_ALARM_CB alarm_cb, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_stop_alarm(UInt32 handle);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_io_alarm_event(UInt32 handle, Int32 chn, Int32 alarm_source_id, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_set_io_alarm_para(UInt32 handle, ref _io_alarm_event_para_list_ p_io_alarm_para);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_set_io_alarm_para(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_io_alarm_para);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_set_disk_alarm_para(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_disk_alarm_para);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_set_disk_alarm_para(UInt32 handle, ref _disk_alarm_event_para_list_ p_disk_alarm_list);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_disk_alarm_para(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_match_alarm_date_list(UInt32 handle, ref _qry_info_list_ p_qry_info, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_get_match_alarm_date_list(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_qry_info, [MarshalAs(UnmanagedType.LPStr)] string s_time, [MarshalAs(UnmanagedType.LPStr)] string e_time, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_alarm_camera_info_list(UInt32 handle, ref _alarm_info_qry_ p_qry_info, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_get_alarm_camera_info_list(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string s_time, [MarshalAs(UnmanagedType.LPStr)] string e_time, [MarshalAs(UnmanagedType.LPStr)] string p_alarm_info_qry, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_alarm_list(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string s_time, [MarshalAs(UnmanagedType.LPStr)] string e_time, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_manual_alarmout(UInt32 handle, Int32 chn, Int32 alarmout_id, Int32 control_flag);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_record_policy(UInt32 handle, Int32 chn, Int32 record_mode, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_set_record_policy(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_record_para);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_record_state(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_last_record_time(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string s_time, [MarshalAs(UnmanagedType.LPStr)] string e_time, [MarshalAs(UnmanagedType.LPStr)] string p_qry_info, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_open_wifi_push(UInt32 handle, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_WIFI_CB wifi_cb, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_close_wifi_push(UInt32 handle);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_open_ptz(UInt32 handle);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_close_ptz(UInt32 handle);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_ptz_stop(UInt32 handle, Int32 chn);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_ptz_rotate(UInt32 handle, Int32 chn, Int32 operation, Int32 speed);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_ptz_zoom(UInt32 handle, Int32 chn, Int32 operation, Int32 speed);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_ptz_focus(UInt32 handle, Int32 chn, Int32 operation);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_ptz_iris(UInt32 handle, Int32 chn, Int32 operation);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_ptz_preset(UInt32 handle, Int32 chn, Int32 id, Int32 operation);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_ptz_track(UInt32 handle, Int32 chn, Int32 id, Int32 operation);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_ptz_scan(UInt32 handle, Int32 chn, Int32 id, Int32 operation);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_ptz_tour(UInt32 handle, Int32 chn, Int32 id, Int32 operation, Int32 speed, Int32 time);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_ptz_keeper(UInt32 handle, Int32 chn, Int32 operation, Int32 enable, Int32 type, Int32 id, Int32 time);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_ptz_threeDimensionalPos(UInt32 handle, Int32 chn, Int32 nX, Int32 nY, Int32 nZoomaTate);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_ptz_brush(UInt32 handle, Int32 chn, Int32 operation, Int32 mode, Int32 waittime);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_ptz_light(UInt32 handle, Int32 chn, Int32 operation);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_ptz_defog(UInt32 handle, Int32 chn, Int32 operation);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_ptz_postion(UInt32 handle, Int32 chn, Int32 operation, Int32 type, Int32 p_nPan, Int32 p_nTilt, Int32 p_nZoom);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_ptz_req(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_ptz_postion(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_set_ptz_speed(UInt32 handle, Int32 chn, Int32 speed);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_ptz_configue(UInt32 handle, Int32 chn, Int32 operation, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_ptz_timer(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_set_ptz_timer(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_get_hw_cap(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_get_sw_cap(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_nw_cap(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_video_cap(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_nvr_cap(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_language_cap(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_time_zone_cap(UInt32 handle, Int32 chn, Int32 language_id, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_get_audio_cap(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_ptz_cap(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_osd_cap(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_get_general_info(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_get_dev_name(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_set_dev_name(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_dev_name);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_get_dev_time(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_set_dev_time(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_dev_time);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_get_dev_ntp(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_set_dev_ntp(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_ntp_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_dev_id(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_set_dev_id(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_dev_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_get_dev_port(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_json_set_dev_port(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_dev_port);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_dev_language(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_set_dev_language(UInt32 handle, Int32 chn, Int32 language_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_dev_time_zone(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_dev_time_zone(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_dev_time);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_chn_info(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_p2p_para(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_set_alarm_push_para(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_alarm_push_para);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_delete_alarm_push_para(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_alarm_push_para);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_security_para(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_set_security_para(UInt32 handle, Int32 web_mode, byte encrypt_enable);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_nvr_channel_name(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_net_param(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_set_net_param(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_net_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_ddns(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_set_ddns(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_net_ddns);

        //[DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        // public static extern Int32 sdk_dev_ddns_test(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)]string p_net_ddns);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_ddns_provider(UInt32 handle, Int32 chn, ref byte p_result);

        //FTP参数
        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_ftp(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_set_ftp(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_net_ftp);

        //[DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        //  public static extern Int32 sdk_dev_ftp_test(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)]string p_ftp_para);
        //SMTP参数
        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_smtp(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_set_smtp(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_net_smtp);

        //  [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        // public static extern Int32 sdk_dev_smtp_test(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)]string p_smtp);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_mtu(UInt32 handle, ref Int32 p_mtu);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_set_mtu(UInt32 handle, Int32 p_mtu);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_osd_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_osd_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_osd_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_blind_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_blind_param(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_blind_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_svc_stream_para(UInt32 handle, Int32 chn, Int32 stream_id, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_roi_param(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_roi_param(UInt32 handle, Int32 chn, Int32 stream, [MarshalAs(UnmanagedType.LPStr)] string p_roi_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_mot_param(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_mot_param(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_mot_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ip_filter_param(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_ip_filter_param(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_ip_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_dev_list(ref byte p_json_out);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_protocol_security_param(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_protocol_security_param(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_protocol_security_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_modify_password_param(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_system_user_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_create_login_password_param(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_creat_login_password_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_operator_privilege_user(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_user_list, ref byte p_result);


        //sensor
        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_reset_sensor_param(UInt32 handle, Int32 chn);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_save_sensor_param(UInt32 handle, Int32 chn);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_reset_sensor_to_last_param(UInt32 handle, Int32 chn);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_sensor_param(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_sensor_para);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_sensor_param(UInt32 handle, Int32 chn, ref byte p_result);

        // [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        //   public static extern Int32 sdk_dev_abb_add_user_info(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)]string p_abb_user_info);

        //  [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        //  public static extern Int32 sdk_dev_abb_delete_user_info(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)]string p_abb_user_info);

        //  [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        //public static extern Int32 sdk_dev_abb_modify_user_info(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)]string p_abb_user_info);

        //[DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        // public static extern Int32 sdk_dev_abb_check_user_info(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)]string p_abb_user_info);

        //[DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        //  public static extern Int32 sdk_dev_abb_update_param(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)]string p_abb_user_info);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_reboot(UInt32 handle, Int32 chn);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_reset(UInt32 handle, Int32 chn, Int32 type);

        //热成像

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_thermal_cap(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_thermal_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_abb_user_info);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_thermal_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_thermal_area_temperature_measure(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_thermal_area_temperature_measure(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_param, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_thermal_area_feature_temperature(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_param, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_thermal_one_point_temperature(UInt32 handle, Int32 chn, Int32 x, Int32 y, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_thermal_any_point_temperature(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_map_relation(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_map_relation(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_temperature_calibration(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_temperature_calibration(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_thermal_version(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_test_thermal_bad_point_correct(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_thermal_bad_point_correct(UInt32 handle, Int32 chn);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_reset_thermal_bad_point_correct(UInt32 handle, Int32 chn);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_thermal_alarm_linkage_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_thermal_alarm_linkage_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_thermal_measurement_parameter(UInt32 handle, int channel, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_thermal_measurement_parameter(UInt32 handle, int channel, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_thermal_live_start(UInt32 handle, Int32 chn, Int32 stream_type, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_DETECT_CB detect_cb, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_thermal_live_stop(UInt32 handle, Int32 stream_id);



        //人脸接口
        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_face_detect_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_face_detect_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_face_detect_start(UInt32 handle, Int32 chn, Int32 stream_type, Int32 type, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_DETECT_CB detect_cb, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_face_detect_stop(UInt32 handle, Int32 stream_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_face_get_group_num(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_face_get_member(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_face_check_data(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_face_get_statis(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_face_get_attendance_data(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param, [MarshalAs(UnmanagedType.LPStr)] string path_file);


        //[DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        // public static extern Int32 sdk_start_database(UInt32 handle, [MarshalAs(UnmanagedType.FunctionPtr)]SDK_FACEBASE_CB facebase_cb_func, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_database_index(UInt32 handle, Int32 chn, byte[] face_data, Int32 size, [MarshalAs(UnmanagedType.LPStr)] string param, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_get_database_info(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        //[DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        //public static extern Int32 sdk_stop_database(UInt32 handle);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_start_face(UInt32 handle, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_FACE_CB face_cb, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_stop_face(UInt32 handle);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_face_get_group(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_face_add_group(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_db_info);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_face_del_group(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_db_info);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_face_rename_group(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_db_info);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_face_get_group_type(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_face_add_group_type(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_db_info);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_face_del_group_type(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_db_info);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_face_all_node(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_param, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_face_by_node(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_info);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_channel_type(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_channel_type(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_lpr_detect_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_lpr_detect_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_lpr_link_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_lpr_link_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_lpr_ipfilter_list_add(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_lpr_ipfilter_list_delete(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_lpr_ipfilter_list_modify(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_lpr_ipfilter_list_num(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_lpr_ipfilter_list(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_lpr_ipfilter_list_search_open(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_lpr_ipfilter_list_search_get(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_lpr_ipfilter_list_search_close(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        // [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        //  public static extern Int32 sdk_lpr_ipfilter_list_file_upload(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)]string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_lpr_ipfilter_list_file_download(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ai_multi_object_detect_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_ai_multi_object_detect_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ai_multi_object_detect_ability(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_device_log(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_param, ref IntPtr p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_version(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_perimeter_ability(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_svf_ability(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_dvf_ability(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_loiter_ability(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_multi_loiter_ability(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_object_left_ability(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_object_removed_ability(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_abnormal_speed_ability(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_converse_ability(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_legal_parking_ability(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_signal_bad_ability(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_advanced_ability(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_perimeter_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_ia_perimeter_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_svf_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_ia_svf_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_dvf_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_ia_dvf_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_loiter_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_ia_loiter_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_multi_loiter_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_ia_multi_loiter_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_object_left_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_ia_object_left_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_object_removed_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_ia_object_removed_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_abnormal_speed_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_ia_abnormal_speed_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_converse_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_ia_converse_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_legal_parking_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_ia_legal_parking_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_signal_bad_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_ia_signal_bad_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_ia_advanced_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_ia_advanced_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_fisheye_ability(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_fisheye_param(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_fisheye_param(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_fisheye_video_layout(UInt32 handle, Int32 chn, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_open_microphone(UInt32 handle, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_MICROPHONE_CB microphone_cb, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_dev_send_audio_data(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_param, Int32 audio_len);
        // public static extern Int32 sdk_dev_send_audio_data(UInt32 handle, IntPtr  p_param, Int32 audio_len);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_close_microphone(UInt32 handle, Int32 audio_id);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_wifi_conn_hots(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_disk_format(UInt32 handle, Int32 chn, Int32 diskid);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 format(Int32 chn);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_update_ipc(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_path);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_update_nvr(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_path);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_mutil_object_downlow_pic_open(UInt32 handle, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_MUTI_OBJ_DOWNLOAD_CB cb, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_nvr_realtime_compare_start(UInt32 handle, Int32 chn, [MarshalAs(UnmanagedType.LPStr)] string p_param, [MarshalAs(UnmanagedType.FunctionPtr)] SDK_MUTI_COMPARE_CB detect_cb, IntPtr p_obj);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_group_compare_alarm_strategy_param(UInt32 handle, Int32 stratege_type, [MarshalAs(UnmanagedType.LPStr)] string p_param, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_group_compare_alarm_strategy_param(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_person_temperature_strategy(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_person_temperature_strategy(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_get_mask_detect_strategy(UInt32 handle, ref byte p_result);

        [DllImport(SdkDll, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 sdk_set_mask_detect_strategy(UInt32 handle, [MarshalAs(UnmanagedType.LPStr)] string p_param);

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _time_struct_
        {
            public Int32 time_zone;              //时区
            public UInt16 day_light_saving_time;   //夏令营时
            public UInt16 year;                    //年
            public UInt16 month;                   //月[1,12]
            public UInt16 day;                 //日[1,31]
            public UInt16 day_of_week;             //星期几[0,6]
            public UInt16 hour;                    //时[0,23]
            public UInt16 minute;              //分[0,59]
            public UInt16 second;              //秒[0,59]
            public Int32 milli_seconds;          //微妙[0,1000000]
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _alarm_info_qry_
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string dev_ip;                    //设备IP
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
            public string dev_id;
            public Int32 source_id;  //报警源Id
            public Int32 select_mode;    //查询模式 :SELECT_MODE_ALL
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string source_name; //源名称
            public Int32 major_type; //报警主类型
            public Int32 minor_type; //报警子类型
            public UInt32 alarm_begin_time; //查询开始时间
            public _time_struct_ alarm_begin_time_struct;
            public UInt32 alarm_end_time;   //查询结束时间
            public _time_struct_ alarm_end_time_struct;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _alarm_action_
        {
            public Int32 action_type;    //报警源类型
            public Int32 action_id;      //报警源ID
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string action_name;     //报警源名称
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _schedule_time_
        {
            public Int32 week_day;
            public UInt32 start_time;
            public UInt32 end_time;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _schedule_time_list_
        {
            public Int32 schedule_time_count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public _schedule_time_[] time_list;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _io_alarm_insource_para_
        {
            public _alarm_action_ alarm_act;
            public Byte enable_flag;  //开启标记
            public Int32 alarm_inval;    //报警间隔
            public Int32 valid_level;    //有效电平
            public _schedule_time_list_ schedule_para;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _alarm_link_t_
        {
            public Int32 action_type;
            public Int32 action_id;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _ptz_action_param_
        {
            public Int32 ptz_action_type;    //操作类型（预置位、轨迹等）
            public Int32 ptz_action_id;      //操作ID（用户之前设置的预置位ID、轨迹ID等）
            public Int32 ptz_channel_id;     //PTZ通道ID
            public _alarm_action_ alarm_act;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _alarm_out_param_
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
            public string dev_id;       //设备id
            public Int32 alarm_out_id;   //报警输出端口的ID号
            public Int32 alarm_out_flag; //报警输出标志          
            public Int32 event_type_id;  //报警事件类型
            public Int32 alarm_time;     //报警输出时间
            public _alarm_action_ alarm_act;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _record_act_param_
        {
            public Byte pre_record_flag; //是否开启预录
            public Int32 delay_record_time;  //延录制时长
            public _alarm_action_ alarm_act;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _io_alarm_event_para_
        {
            public _io_alarm_insource_para_ insource_para;
            public Int32 linkage_param_count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public _alarm_link_t_[] link_param_list;
            public Int32 ptz_action_action_param_list_count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public _ptz_action_param_[] ptz_param_list;
            public Int32 alarm_out_count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public _alarm_out_param_[] alarm_out_list;
            public Int32 record_action_param_list_count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public _record_act_param_[] record_action_list;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _io_alarm_event_para_list_
        {
            public Int32 alarm_event_list_count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public _io_alarm_event_para_[] alarm_event_list;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _disk_alarm_source_para_
        {
            public _alarm_action_ alarm_act;
            public UInt16 enable_flag;   //是否启动磁盘报警(false：不启动， true：启动)
            public Int32 alarm_inval;    //上报间隔，单位为秒，最小间隔为10秒，最大为86400秒(1天)
            public Int32 alarm_thresold; //报警阈值, 单位为百分比
            public UInt16 disk_full_enable_flag;
            public UInt16 disk_error_enable_flag;
            public UInt16 no_disk_enable_flag;
            public _schedule_time_list_ schedule_para;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _disk_alarm_event_para_
        {
            public _disk_alarm_source_para_ disk_alarm_source;
            public Int32 linkage_param_count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public _alarm_link_t_[] link_param_list;
            public Int32 ptz_action_action_param_list_count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public _ptz_action_param_[] ptz_param_list;
            public Int32 alarm_out_count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public _alarm_out_param_[] alarm_out_list;
            public Int32 record_action_param_list_count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public _record_act_param_[] record_action_list;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _disk_alarm_event_para_list_
        {
            public Int32 disk_alarm_event_count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public _disk_alarm_event_para_[] disk_alarm_event_list;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _qry_info_
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
            public string dev_id;       //设备ID
            public Int32 channel_id;    //通道号
            public Int32 record_mode;   //查询模式(录像查询or快照查询)
            public Int32 select_mode;   //查询模式(0:所有；1：按类型查询；2：按时间查询)
            public Int32 major_type;    //主类型
            public Int32 minor_type;    //次类型
            public Int32 precision;     //精度
            public Int32 record_segment_interval;        //查询段时间长度（每段最长时间跨度）
            public _time_struct_ begin_time;             //开始时间
            public _time_struct_ end_time;               //结束时间
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _qry_info_list_
        {
            public Int32 qry_info_count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public _qry_info_[] qry_info_list;
        }
    }
}
