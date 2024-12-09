﻿using System;

namespace Mtf.Controls.Sunell.CustomEventArgs
{
    public class VideoSignalChangedEventArgs : EventArgs
    {
        public VideoSignalChangedEventArgs(bool hasSignal)
        {
            HasSignal = hasSignal;
        }

        public bool HasSignal { get; private set; }
    }
}
