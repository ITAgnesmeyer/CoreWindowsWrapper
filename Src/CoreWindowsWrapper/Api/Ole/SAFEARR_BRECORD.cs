using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SAFEARR_BRECORD
    {
        /// ULONG->unsigned int
        public uint Size;

        /// wireBRECORD*
        public IntPtr aRecord;
    }
}