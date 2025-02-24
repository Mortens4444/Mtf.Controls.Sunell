﻿namespace Mtf.Controls.Sunell.IPR66.SunellSdk
{
    public enum SunellEventID
    {
        EVENTID_CREATE_VIDEO_SESSION_SUCCESS = 1,
        EVENTID_CREATE_AUDIO_SESSION_SUCCESS = 2,
        EVENTID_CREATE_VIDEO_SESSION_FAILED = 3,
        EVENTID_CREATE_AUDIO_SESSION_FAILED = 4,
        EVNETID_VIDEO_SESSION_CLOSED_SUCCESS = 5,
        EVENTID_AUDIO_SESSION_CLOSED_SUCCESS = 6,
        EVENTID_LOGIN_USERNAME_WRONG = 7,
        EVENTID_LOGIN_PASSWORD_WRONG = 8,
        EVENTID_LOGIN_USER_REPEATED = 16,
        EVENTID_RECEIVE_VIDEO_ERROR = 9,
        EVENTID_RECEIVE_AUDIO_ERROR = 10,
        EVENTID_DEVICE_NOT_SUPPORT_VIDEO = 11,
        EVENTID_DEVICE_NOT_SUPPORT_AUDIO = 12,
        EVENTID_DEVICE_NO_PRIVILEGE = 13,
        EVENTID_DEVICE_MAX_CONNECTION = 14,
        EVENTID_FILE_PLAYBACK_END = 15
    }
}
