using System;
using System.Runtime.InteropServices;

// ReSharper disable IdentifierTypo

namespace CoreWindowsWrapper.Api.Win32
{

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    internal struct WndclassEx
    {
        public int cbSize;
        public uint style;
        public WndProc lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public IntPtr hInstance;
        public IntPtr hIcon;
        public IntPtr hCursor;
        public IntPtr hbrBackground;
        public string lpszMenuName;
        public string lpszClassName;
        public IntPtr hIconSm;


    }

   

}