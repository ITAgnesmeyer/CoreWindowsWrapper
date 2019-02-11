using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleAdviseHolder
    {
        /// IOleAdviseHolderVtbl*
        public IntPtr lpVtbl;
    }
}