using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SAFEARR_VARIANT
    {
        /// ULONG->unsigned int
        public uint Size;

        /// wireVARIANT*
        public IntPtr aVariant;
    }
}