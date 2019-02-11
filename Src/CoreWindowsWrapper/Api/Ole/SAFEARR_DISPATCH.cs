using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SAFEARR_DISPATCH
    {
        /// ULONG->unsigned int
        public uint Size;

        /// IDispatch**
        public IntPtr apDispatch;
    }
}