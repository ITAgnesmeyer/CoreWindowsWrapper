using System;
using System.Runtime.InteropServices;
using System.Text;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

namespace CoreWindowsWrapper.Api.Win32
{
    internal static class Kernel32
    {
        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpLibFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryW")]
        public static extern IntPtr LoadLibrary([In, MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName);

        [DllImport("kernel32.dll")]
        public static extern ushort GetSystemDefaultLangID();

        /// Return Type: DWORD->unsigned int
        ///Process: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessId")]
        public static extern uint GetProcessId([In] IntPtr Process);

        /// Return Type: HFILE->int
        ///lpFileName: LPCSTR->CHAR*
        ///lpReOpenBuff: LPOFSTRUCT->_OFSTRUCT*
        ///uStyle: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "OpenFile")]
        public static extern int OpenFile([In, MarshalAs(UnmanagedType.LPStr)] string lpFileName, ref OFSTRUCT lpReOpenBuff, uint uStyle);

        [DllImport("kernel32.dll", EntryPoint = "CopyMemory", SetLastError = false)]
        public static extern void CopyMemory(IntPtr dest, IntPtr src, uint count);


        /// Return Type: int
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrlenW")]
        public static extern int lstrlenW([In, MarshalAs(UnmanagedType.LPWStr)] string lpString);

        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemDirectoryW")]
        public static extern uint GetSystemDirectory([Out, MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder lpBuffer, uint uSize);

        /// Return Type: BOOL->int
        ///hActCtx: HANDLE->void*
        ///lpCookie: ULONG_PTR*
        [DllImport("kernel32.dll", EntryPoint = "ActivateActCtx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ActivateActCtx(IntPtr hActCtx, [Out] out uint lpCookie);

        /// Return Type: HANDLE->void*
        ///pActCtx: PCACTCTXW->ACTCTXW*
        [DllImport("kernel32.dll", EntryPoint = "CreateActCtxW")]
        public static extern IntPtr CreateActCtx([In] ref ACTCTX pActCtx);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwProcessId);

        /// Return Type: BOOL->int
        ///hObject: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle([In] IntPtr hObject);

        public static IntPtr GetProcessHandleFromId(uint dwProcessId)
        {
            return OpenProcess((uint)ProcessAccessTypes.SYNCHRONIZE, true, dwProcessId);
        }
    }
}


