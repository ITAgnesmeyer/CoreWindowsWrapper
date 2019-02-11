using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleCache
    {
        /// IOleCacheVtbl*
        public IntPtr lpVtbl;
    }
}