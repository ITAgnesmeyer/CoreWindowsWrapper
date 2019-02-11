using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSOLE_AUTHENTICATION_INFO
    {
        /// DWORD->unsigned int
        public uint dwAuthnSvc;

        /// DWORD->unsigned int
        public uint dwAuthzSvc;

        /// void*
        public IntPtr pAuthInfo;
    }
}