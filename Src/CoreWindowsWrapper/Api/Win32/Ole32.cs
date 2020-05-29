using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    internal static class Ole32
    {
        ///pvReserved: LPVOID->void*
        [DllImport("ole32.dll", EntryPoint = "OleInitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleInitialize(IntPtr pvReserved);

        /// Return Type: void
        [DllImport("ole32.dll", EntryPoint = "OleUninitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern void OleUninitialize();
    }
}