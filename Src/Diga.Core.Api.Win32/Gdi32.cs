using System;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

namespace Diga.Core.Api.Win32
{
    public static class Gdi32
    {
        private const string GDI32 = "gdi32.dll";
        private const CharSet CHARSET = CharSet.Auto;


        [DllImport(GDI32, EntryPoint="AddFontResource",CharSet =CHARSET)]
        public static extern  int AddFontResource([In] string param0) ;

        [DllImport(GDI32, EntryPoint="AddFontResourceEx",CharSet =CHARSET)]
        public static extern  int AddFontResourceEx([In]  string name, uint fl, IntPtr res) ;

        [DllImport(GDI32, EntryPoint="DeleteObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool DeleteObject([In] IntPtr ho) ;


        [DllImport(GDI32, EntryPoint = "GetDeviceCaps")]
        public static extern int GetDeviceCaps([In] IntPtr hdc, int index);

        [DllImport(GDI32, EntryPoint = "CreateFontIndirect",CharSet = CHARSET)]
        public static extern IntPtr CreateFontIndirect([In] ref LogFont lplf);


        [DllImport(GDI32, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetObject(IntPtr hObject, int nSize, [In, Out] LogFont lf);


        public static int GetObject(IntPtr hObject, LogFont lp)
        {
            return GetObject(hObject, Marshal.SizeOf(typeof(LogFont)), lp);
        }


        [DllImport(GDI32, EntryPoint = "CreateSolidBrush", SetLastError = true)]
        public static extern IntPtr CreateSolidBrush(int crColor);


        [DllImport(GDI32, EntryPoint = "SetBkColor", SetLastError = true)]
        public static extern uint SetBkColor(IntPtr hdc, int crColor);

        [DllImport(GDI32, EntryPoint = "SetTextColor", SetLastError = true)]
        public static extern uint SetTextColor(IntPtr hdc, int crColor);

        [DllImport(GDI32, EntryPoint = "GetStockObject", SetLastError = true)]
        public static extern IntPtr GetStockObject(StockObjects fnObject);

        [DllImport(GDI32, EntryPoint="RemoveFontResourceEx",CharSet =CHARSET)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool RemoveFontResourceEx([In]  string name, uint fl, IntPtr pdv) ;



        public static int RGB(int r, int g, int b) => checked(checked(checked(b * 65536) + checked(g * 256)) + r);
    }
}


