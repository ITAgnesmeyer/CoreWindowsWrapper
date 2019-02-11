using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_999607ba_8a31_4480_af49_8774cb4f5bd6
    {
        /// tagTYPEDESC*
        [FieldOffset(0)]
        public IntPtr lptdesc;

        /// tagARRAYDESC*
        [FieldOffset(0)]
        public IntPtr lpadesc;

        /// HREFTYPE->DWORD->unsigned int
        [FieldOffset(0)]
        public uint hreftype;
    }
}