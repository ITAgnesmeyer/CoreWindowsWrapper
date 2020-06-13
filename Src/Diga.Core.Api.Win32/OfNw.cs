// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

using System;
using System.Runtime.InteropServices;

namespace Diga.Core.Api.Win32
{
    [StructLayout(LayoutKind.Sequential,CharSet =CharSet.Auto)]
    public struct OfNw
    {
        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPCWSTR->WCHAR*
        public string lpstrFilter;

        /// LPWSTR->WCHAR*
        public string lpstrCustomFilter;

        /// DWORD->unsigned int
        public uint nMaxCustFilter;

        /// DWORD->unsigned int
        public uint nFilterIndex;

        /// LPWSTR->WCHAR*
        public string lpstrFile;

        /// DWORD->unsigned int
        public uint nMaxFile;

        /// LPWSTR->WCHAR*
        public string lpstrFileTitle;

        /// DWORD->unsigned int
        public uint nMaxFileTitle;

        /// LPCWSTR->WCHAR*
        public string lpstrInitialDir;

        /// LPCWSTR->WCHAR*
        public string lpstrTitle;

        /// DWORD->unsigned int
        public uint Flags;

        /// WORD->unsigned short
        public ushort nFileOffset;

        /// WORD->unsigned short
        public ushort nFileExtension;

        /// LPCWSTR->WCHAR*
        public string lpstrDefExt;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPOFNHOOKPROC
        public LpOfNHookProc lpfnHook;

        /// LPCWSTR->WCHAR*
        public string lpTemplateName;

        /// void*
        public IntPtr pvReserved;

        /// DWORD->unsigned int
        public uint dwReserved;

        /// DWORD->unsigned int
        public uint FlagsEx;
    }
}


