using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SAFEARR_BSTR
    {
        /// ULONG->unsigned int
        public uint Size;

        /// wireBSTR*
        public IntPtr aBstr;
    }
}