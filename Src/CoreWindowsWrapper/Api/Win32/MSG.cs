using System;

// ReSharper disable InconsistentNaming

namespace CoreWindowsWrapper.Api.Win32
{
    public struct MSG
    {
        public IntPtr hwnd;
        public uint message;
        public IntPtr wParam;
        public IntPtr lParam;
        public uint time;
        public Point pt;
    }
}