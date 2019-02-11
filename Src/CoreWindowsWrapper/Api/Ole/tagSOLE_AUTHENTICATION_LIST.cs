using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSOLE_AUTHENTICATION_LIST
    {
        /// DWORD->unsigned int
        public uint cAuthInfo;

        /// SOLE_AUTHENTICATION_INFO*
        public IntPtr aAuthInfo;
    }
}