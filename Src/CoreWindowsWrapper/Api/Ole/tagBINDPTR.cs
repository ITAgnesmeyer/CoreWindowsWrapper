using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Explicit)]
    public struct tagBINDPTR
    {
        /// FUNCDESC*
        [FieldOffset(0)]
        public IntPtr lpfuncdesc;

        /// VARDESC*
        [FieldOffset(0)]
        public IntPtr lpvardesc;

        /// ITypeComp*
        [FieldOffset(0)]
        public IntPtr lptcomp;
    }
}