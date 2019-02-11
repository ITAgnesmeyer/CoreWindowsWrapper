using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleCache2
    {
        /// IOleCache2Vtbl*
        public IntPtr lpVtbl;
    }
}