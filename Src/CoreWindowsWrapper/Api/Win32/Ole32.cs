﻿using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    internal static class Ole32
    {
        private const string OLE32 = "ole32.dll";
        ///pvReserved: LPVOID->void*
        [DllImport(OLE32, EntryPoint = "OleInitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleInitialize(IntPtr pvReserved);

        /// Return Type: void
        [DllImport(OLE32, EntryPoint = "OleUninitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern void OleUninitialize();
    }
}