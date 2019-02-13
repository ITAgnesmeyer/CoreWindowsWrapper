using System;

// ReSharper disable InconsistentNaming

namespace CoreWindowsWrapper.Api.Win32
{
    internal struct MSG
    {
        public IntPtr hwnd;
        public uint message;
        public IntPtr wParam;
        public IntPtr lParam;
        public uint time;
        public Point pt;
    }
}