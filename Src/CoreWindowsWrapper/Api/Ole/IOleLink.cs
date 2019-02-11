using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleLink
    {
        /// IOleLinkVtbl*
        public IntPtr lpVtbl;
    }
}