using System;
using System.Runtime.InteropServices;
using System.Text;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

namespace Diga.Core.Api.Win32
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall,CharSet =CharSet.Auto)]
    public delegate int ENUMRESNAMEPROC([In] IntPtr hModule, [In] string lpType, [In] string lpName, [In] IntPtr lParam);

    [UnmanagedFunctionPointer(CallingConvention.StdCall,CharSet =CharSet.Auto)]
    public delegate int ENUMRESTYPEPROC([In] IntPtr hModule, [In] string lpType, [In] IntPtr lParam);

    [UnmanagedFunctionPointer(CallingConvention.StdCall,CharSet = CharSet.Auto)]
    public delegate int ENUMRESLANGPROC([In] IntPtr hModule, [In]  string lpType, [In]  string lpName, ushort wLanguage, [In] IntPtr lParam);


    public static class Kernel32
    {
        private const string KERNEL32 = "kernel32.dll";
        private const CharSet CHARSET = CharSet.Auto;
        [DllImport(KERNEL32)]
        public static extern uint GetLastError();

      
        [DllImport(KERNEL32, EntryPoint = "LoadLibrary",CharSet =CHARSET)]
        public static extern IntPtr LoadLibrary([In] string lpLibFileName);

        [DllImport(KERNEL32)]
        public static extern ushort GetSystemDefaultLangID();

    
        [DllImport(KERNEL32, EntryPoint = "GetProcessId")]
        public static extern uint GetProcessId([In] IntPtr Process);

    
        [DllImport(KERNEL32, EntryPoint = "OpenFile",CharSet =CHARSET)]
        public static extern int OpenFile([In] string lpFileName, ref OFSTRUCT lpReOpenBuff, uint uStyle);

        [DllImport(KERNEL32, EntryPoint = "CopyMemory", SetLastError = false)]
        public static extern void CopyMemory(IntPtr dest, IntPtr src, uint count);


        [DllImport(KERNEL32, EntryPoint="GetModuleHandle", CharSet = CHARSET)]
        public static extern  IntPtr GetModuleHandleW([In]  string lpModuleName) ;

        
       
        [DllImport(KERNEL32, EntryPoint = "lstrlen",CharSet =CHARSET)]
        public static extern int lstrlen([In] string lpString);

       
        [DllImport(KERNEL32, EntryPoint = "GetSystemDirectory",CharSet =CHARSET)]
        public static extern uint GetSystemDirectory([Out]
            StringBuilder lpBuffer, uint uSize);

       
        [DllImport(KERNEL32, EntryPoint = "ActivateActCtx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ActivateActCtx(IntPtr hActCtx, [Out] out uint lpCookie);

       
        [DllImport(KERNEL32, EntryPoint = "CreateActCtx", CharSet = CHARSET)]
        public static extern IntPtr CreateActCtx([In] ref ActCtx pActCtx);


       
        [DllImport(KERNEL32, EntryPoint = "OpenProcess")]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwProcessId);

       
        [DllImport(KERNEL32, EntryPoint = "CloseHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle([In] IntPtr hObject);

        public static IntPtr GetProcessHandleFromId(uint dwProcessId)
        {
            return OpenProcess((uint)ProcessAccessTypes.SYNCHRONIZE, true, dwProcessId);
        }

        [DllImport(KERNEL32, EntryPoint="FreeResource")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool FreeResource([In] IntPtr hResData) ;

        [DllImport(KERNEL32, EntryPoint="LoadResource")]
        public static extern  IntPtr LoadResource([In] IntPtr hModule, [In] IntPtr hResInfo) ;


        [DllImport(KERNEL32, EntryPoint="LockResource")]
        public static extern  IntPtr LockResource([In] IntPtr hResData) ;

        [DllImport(KERNEL32, EntryPoint="FindResource",CharSet = CHARSET)]
        public static extern  IntPtr FindResource([In] IntPtr hModule, [In]  string lpName, [In] string lpType) ;

        [DllImport(KERNEL32, EntryPoint="SizeofResource")]
        public static extern  uint SizeofResource([In] IntPtr hModule, [In] IntPtr hResInfo) ;

        [DllImport(KERNEL32, EntryPoint="FindResourceEx",CharSet =CHARSET)]
        public static extern  IntPtr FindResourceEx([In] IntPtr hModule, [In] string lpType, [In] string lpName, ushort wLanguage) ;

        
        [DllImport(KERNEL32, EntryPoint="UpdateResource",CharSet =CHARSET)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool UpdateResource([In] IntPtr hUpdate, [In] string lpType, [In] string lpName, ushort wLanguage, [In] IntPtr lpData, uint cb) ;

        [DllImport(KERNEL32, EntryPoint="EndUpdateResource",CharSet =CHARSET)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool EndUpdateResource([In] IntPtr hUpdate, [MarshalAs(UnmanagedType.Bool)] bool fDiscard) ;


        [DllImport(KERNEL32, EntryPoint="EnumResourceNames",CharSet =CHARSET)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool EnumResourceNames([In] IntPtr hModule, [In] string lpType, ENUMRESNAMEPROC lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam) ;


        [DllImport(KERNEL32, EntryPoint="EnumResourceTypes",CharSet =CHARSET)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool EnumResourceTypes([In] IntPtr hModule, ENUMRESTYPEPROC lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam) ;

        [DllImport(KERNEL32, EntryPoint = "BeginUpdateResource",CharSet =CHARSET)]
        public static extern IntPtr BeginUpdateResource([In] string pFileName, [MarshalAs(UnmanagedType.Bool)] bool bDeleteExistingResources);

        [DllImport(KERNEL32, EntryPoint="EnumResourceLanguages",CharSet =CHARSET)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool EnumResourceLanguages([In] IntPtr hModule, [In] string lpType, [In] string lpName, ENUMRESLANGPROC lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] int lParam) ;

        [DllImport(KERNEL32, EntryPoint="QueryMemoryResourceNotification")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool QueryMemoryResourceNotification([In] IntPtr ResourceNotificationHandle, [Out] out int ResourceState) ;

        [DllImport(KERNEL32, EntryPoint="CreateMemoryResourceNotification")]
        public static extern  IntPtr CreateMemoryResourceNotification(MEMORY_RESOURCE_NOTIFICATION_TYPE NotificationType) ;


    }
}


