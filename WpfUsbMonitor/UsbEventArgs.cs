﻿using System;

namespace WpfUsbMonitor
{
    /// <summary>
    /// A class for containing USB event data
    /// </summary>
    public class UsbEventArgs : EventArgs
    {
        internal UsbEventArgs(UsbDeviceAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Device action
        /// </summary>
        public UsbDeviceAction Action { get; private set; }

        /// <summary>
        /// Override ToString
        /// </summary>
        /// <returns>Debug string</returns>
        public override string ToString()
        {
            return $"{Action}";
        }
    }
}
