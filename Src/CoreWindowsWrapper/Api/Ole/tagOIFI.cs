using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagOIFI
    {
        /// UINT->unsigned int
        public uint cb;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fMDIApp;

        /// HWND->HWND__*
        public IntPtr hwndFrame;

        /// HACCEL->HACCEL__*
        public IntPtr haccel;

        /// UINT->unsigned int
        public uint cAccelEntries;
    }
}