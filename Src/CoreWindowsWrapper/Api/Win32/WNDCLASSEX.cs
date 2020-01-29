using System;
using System.Runtime.InteropServices;

// ReSharper disable IdentifierTypo

namespace CoreWindowsWrapper.Api.Win32
{
    /// Return Type: LRESULT->LONG_PTR->int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: WPARAM->UINT_PTR->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate int WNDPROC(System.IntPtr param0, uint param1, System.IntPtr param2, System.IntPtr param3);


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    //[StructLayout(LayoutKind.Sequential)]
    internal struct Wndclassex
    {
        [MarshalAs(UnmanagedType.U4)] public int cbSize;
        [MarshalAs(UnmanagedType.U4)] public uint style;
        public IntPtr lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public IntPtr hInstance;
        public IntPtr hIcon;
        public IntPtr hCursor;
        public IntPtr hbrBackground;
        public string lpszMenuName;
        public string lpszClassName;
        public IntPtr hIconSm;

        public static Wndclassex Build()
        {
            var nw = new Wndclassex();
            nw.cbSize = Marshal.SizeOf(typeof(Wndclassex));
            return nw;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WndclassexW {
    
     
        /// UINT->unsigned int
        public uint cbSize;
    
        /// UINT->unsigned int
        public uint style;
    
        /// WNDPROC
        public WNDPROC lpfnWndProc;
    
        /// int
        public int cbClsExtra;
    
        /// int
        public int cbWndExtra;
    
        /// HINSTANCE->HINSTANCE__*
        public System.IntPtr hInstance;
    
        /// HICON->HICON__*
        public System.IntPtr hIcon;
    
        /// HCURSOR->HICON->HICON__*
        public System.IntPtr hCursor;
    
        /// HBRUSH->HBRUSH__*
        public System.IntPtr hbrBackground;
    
        /// LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
        public string lpszMenuName;
    
        /// LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
        public string lpszClassName;
    
        /// HICON->HICON__*
        public System.IntPtr hIconSm;

    }


    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct WndclassexA {
    
        /// UINT->unsigned int
        public uint cbSize;
    
        /// UINT->unsigned int
        public uint style;
    
        /// WNDPROC
        public WNDPROC lpfnWndProc;
    
        /// int
        public int cbClsExtra;
    
        /// int
        public int cbWndExtra;
    
        /// HINSTANCE->HINSTANCE__*
        public System.IntPtr hInstance;
    
        /// HICON->HICON__*
        public System.IntPtr hIcon;
    
        /// HCURSOR->HICON->HICON__*
        public System.IntPtr hCursor;
    
        /// HBRUSH->HBRUSH__*
        public System.IntPtr hbrBackground;
    
        /// LPCSTR->CHAR*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string lpszMenuName;
    
        /// LPCSTR->CHAR*
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string lpszClassName;
    
        /// HICON->HICON__*
        public System.IntPtr hIconSm;

    }

}