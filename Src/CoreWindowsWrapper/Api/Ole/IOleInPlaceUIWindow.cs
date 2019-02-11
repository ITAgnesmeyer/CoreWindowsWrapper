using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleInPlaceUIWindow
    {
        /// IOleInPlaceUIWindowVtbl*
        public IntPtr lpVtbl;
    }
}