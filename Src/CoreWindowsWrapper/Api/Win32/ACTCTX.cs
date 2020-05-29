﻿using System;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

namespace CoreWindowsWrapper.Api.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct ACTCTX
    {


        public int cbSize;
        public uint dwFlags;
        public string lpSource;
        public ushort wProcessorArchitecture;
        public ushort wLangId;
        public string lpAssemblyDirectory;
        public IntPtr lpResourceName;
        public string lpApplicationName;

    }
}


