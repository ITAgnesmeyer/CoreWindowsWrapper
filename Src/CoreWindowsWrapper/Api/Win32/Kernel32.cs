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

      
        [DllImport("kernel32.dll", EntryPoint = "LoadLibrary",CharSet =CharSet.Auto)]
        public static extern IntPtr LoadLibrary([In] string lpLibFileName);

        [DllImport("kernel32.dll")]
        public static extern ushort GetSystemDefaultLangID();

    
        [DllImport("kernel32.dll", EntryPoint = "GetProcessId")]
        public static extern uint GetProcessId([In] IntPtr Process);

    
        [DllImport("kernel32.dll", EntryPoint = "OpenFile",CharSet =CharSet.Auto)]
        public static extern int OpenFile([In] string lpFileName, ref OFSTRUCT lpReOpenBuff, uint uStyle);

        [DllImport("kernel32.dll", EntryPoint = "CopyMemory", SetLastError = false)]
        public static extern void CopyMemory(IntPtr dest, IntPtr src, uint count);


        [DllImport("kernel32.dll", EntryPoint="GetModuleHandle", CharSet = CharSet.Auto)]
        public static extern  IntPtr GetModuleHandleW([In()]  string lpModuleName) ;

        
       
        [DllImport("kernel32.dll", EntryPoint = "lstrlen",CharSet =CharSet.Auto)]
        public static extern int lstrlen([In] string lpString);

       
        [DllImport("kernel32.dll", EntryPoint = "GetSystemDirectory",CharSet =CharSet.Auto)]
        public static extern uint GetSystemDirectory([Out]
            StringBuilder lpBuffer, uint uSize);

       
        [DllImport("kernel32.dll", EntryPoint = "ActivateActCtx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ActivateActCtx(IntPtr hActCtx, [Out] out uint lpCookie);

       
        [DllImport("kernel32.dll", EntryPoint = "CreateActCtx", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateActCtx([In] ref ActCtx pActCtx);


       
        [DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwProcessId);

       
        [DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle([In] IntPtr hObject);

        public static IntPtr GetProcessHandleFromId(uint dwProcessId)
        {
            return OpenProcess((uint)ProcessAccessTypes.SYNCHRONIZE, true, dwProcessId);
        }
    }
}


