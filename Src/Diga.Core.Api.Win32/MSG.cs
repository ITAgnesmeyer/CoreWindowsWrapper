using System;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming

namespace Diga.Core.Api.Win32
{
    [StructLayout(LayoutKind.Sequential,CharSet =CharSet.Auto)]
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