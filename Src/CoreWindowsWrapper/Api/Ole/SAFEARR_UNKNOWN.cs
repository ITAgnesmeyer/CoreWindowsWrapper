using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SAFEARR_UNKNOWN
    {
        /// ULONG->unsigned int
        public uint Size;

        /// IUnknown**
        public IntPtr apUnknown;
    }
}