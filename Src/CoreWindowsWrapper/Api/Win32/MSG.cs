using System;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming

namespace CoreWindowsWrapper.Api.Win32
{
    [StructLayout(LayoutKind.Sequential,CharSet =CharSet.Auto)]
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