using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    struct Paintstruct {
        public IntPtr hdc;
        public bool fErase;
        public Rect rcPaint;
        public bool fRestore;
        public bool fIncUpdate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)] public byte [] rgbReserved;
    }
}