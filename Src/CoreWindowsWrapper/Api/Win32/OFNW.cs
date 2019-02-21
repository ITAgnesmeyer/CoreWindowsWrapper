// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    /// Return Type: UINT_PTR->unsigned int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: WPARAM->UINT_PTR->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LPOFNHOOKPROC(System.IntPtr param0, uint param1, System.IntPtr param2, System.IntPtr param3);


    [StructLayout(LayoutKind.Sequential)]
    public struct OFNW
    {
        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public System.IntPtr hwndOwner;

        /// HINSTANCE->HINSTANCE__*
        public System.IntPtr hInstance;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)] public string lpstrFilter;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)] public string lpstrCustomFilter;

        /// DWORD->unsigned int
        public uint nMaxCustFilter;

        /// DWORD->unsigned int
        public uint nFilterIndex;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)] public string lpstrFile;

        /// DWORD->unsigned int
        public uint nMaxFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)] public string lpstrFileTitle;

        /// DWORD->unsigned int
        public uint nMaxFileTitle;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)] public string lpstrInitialDir;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)] public string lpstrTitle;

        /// DWORD->unsigned int
        public uint Flags;

        /// WORD->unsigned short
        public ushort nFileOffset;

        /// WORD->unsigned short
        public ushort nFileExtension;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)] public string lpstrDefExt;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPOFNHOOKPROC
        public LPOFNHOOKPROC lpfnHook;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)] public string lpTemplateName;

        /// void*
        public System.IntPtr pvReserved;

        /// DWORD->unsigned int
        public uint dwReserved;

        /// DWORD->unsigned int
        public uint FlagsEx;
    }
}


