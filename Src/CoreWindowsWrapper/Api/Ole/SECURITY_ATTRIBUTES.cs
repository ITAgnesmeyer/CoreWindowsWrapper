using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_ATTRIBUTES
    {
        /// DWORD->unsigned int
        public uint nLength;

        /// LPVOID->void*
        public IntPtr lpSecurityDescriptor;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool bInheritHandle;
    }
}