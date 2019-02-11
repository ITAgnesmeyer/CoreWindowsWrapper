using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagDISPPARAMS
    {
        /// VARIANTARG*
        public IntPtr rgvarg;

        /// DISPID*
        public IntPtr rgdispidNamedArgs;

        /// UINT->unsigned int
        public uint cArgs;

        /// UINT->unsigned int
        public uint cNamedArgs;
    }
}