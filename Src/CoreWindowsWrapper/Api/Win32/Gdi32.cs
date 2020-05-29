using System;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

namespace CoreWindowsWrapper.Api.Win32
{
    internal static class Gdi32
    {
        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///index: int
        [DllImport("gdi32.dll", EntryPoint = "GetDeviceCaps")]
        public static extern int GetDeviceCaps([In] IntPtr hdc, int index);

        /// Return Type: HFONT->HFONT__*
        ///lplf: LOGFONTW*
        [DllImport("gdi32.dll", EntryPoint = "CreateFontIndirectW")]
        public static extern IntPtr CreateFontIndirect([In] ref LogFont lplf);


        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetObject(IntPtr hObject, int nSize, [In, Out] LogFont lf);

        /// Return Type: int
        ///h: HANDLE->void*
        ///c: int
        ///pv: LPVOID->void*
        //[DllImport("gdi32.dll", EntryPoint = "GetObjectW")]
        //public static extern int GetObjectW([In] IntPtr h, int c, IntPtr pv);


        public static int GetObject(IntPtr hObject, LogFont lp)
        {
            return GetObject(hObject, Marshal.SizeOf(typeof(LogFont)), lp);
        }


        [DllImport("gdi32.dll", EntryPoint = "CreateSolidBrush", SetLastError = true)]
        public static extern IntPtr CreateSolidBrush(int crColor);


        [DllImport("gdi32.dll", EntryPoint = "SetBkColor", SetLastError = true)]
        public static extern uint SetBkColor(IntPtr hdc, int crColor);

        [DllImport("gdi32.dll")]
        public static extern uint SetTextColor(IntPtr hdc, int crColor);

        [DllImport("gdi32.dll")]
        public static extern IntPtr GetStockObject(StockObjects fnObject);

        public static int RGB(int r, int g, int b) => checked(checked(checked(b * 65536) + checked(g * 256)) + r);
    }
}


