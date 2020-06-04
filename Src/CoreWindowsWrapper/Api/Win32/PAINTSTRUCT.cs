﻿using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct PaintStruct
    {
        public IntPtr hdc;
        [MarshalAs(UnmanagedType.Bool)]
        public bool fErase;
        public Rect rcPaint;
        [MarshalAs(UnmanagedType.Bool)]
        public bool fRestore;
        [MarshalAs(UnmanagedType.Bool)]
        public bool fIncUpdate;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] rgbReserved;
    }
}