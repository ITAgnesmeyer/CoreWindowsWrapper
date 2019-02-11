using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IEnumMoniker
    {
        /// IEnumMonikerVtbl*
        public IntPtr lpVtbl;
    }
}