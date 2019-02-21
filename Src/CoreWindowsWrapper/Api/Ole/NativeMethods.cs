using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CoreWindowsWrapper.Api.Ole
{
    [SuppressUnmanagedCodeSecurity]
    internal static class NativeMethods
    {

        [DllImport("atl.dll", EntryPoint = "AtlAxAttachControl")]
        public static extern IntPtr AtlAxAttachControl(object unknown, IntPtr hWndParent, IntPtr uunknown);

        [DllImport("ole32.dll", CharSet=CharSet.None, PreserveSig=false,EntryPoint = "CoCreateInstance", SetLastError = true)]
        public static extern object CoCreateInstance([In] ref Guid clsid, object punkOuter, int context, [In] ref Guid iid);

            
        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///pUnkOuter: LPUNKNOWN->IUnknown*
        ///dwClsContext: DWORD->unsigned int
        ///riid: IID*
        ///ppv: LPVOID*
        [DllImport("ole32.dll", EntryPoint="CoCreateInstance", CallingConvention=CallingConvention.StdCall)]
        public static extern  int CoCreateInstance(ref Guid rclsid, ref object pUnkOuter, uint dwClsContext, ref Guid riid, ref IntPtr ppv) ;


            
        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///pUnkOuter: LPUNKNOWN->IUnknown*
        ///dwClsContext: DWORD->unsigned int
        ///riid: IID*
        ///ppv: LPVOID*
        [DllImport("ole32.dll", EntryPoint="CoCreateInstance", CallingConvention=CallingConvention.StdCall)]
        public static extern  int CoCreateInstance(ref Guid rclsid, ref IntPtr pUnkOuter, uint dwClsContext, ref Guid riid, ref IntPtr ppv) ;

        
        /// Return Type: HRESULT->LONG->int
        ///lpsz: LPOLESTR->OLECHAR*
        ///lpiid: LPIID->IID*
        [DllImport("ole32.dll", EntryPoint="IIDFromString", CallingConvention=CallingConvention.StdCall)]
        public static extern  int IIDFromString(IntPtr lpsz, ref Guid lpiid) ;

        //[DllImport("ole32.dll", CharSet=CharSet.Unicode, PreserveSig=false)]
        //[return:MarshalAs(UnmanagedType.LPStruct)]
        //public static extern GUID IIDFromString(string lpsz);


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///lplpsz: LPOLESTR*
        [DllImport("ole32.dll", EntryPoint="StringFromIID", CallingConvention=CallingConvention.StdCall)]
        public static extern  int StringFromIID(ref Guid rclsid, ref IntPtr lplpsz) ;


        /// Return Type: HRESULT->LONG->int
        ///pvReserved: LPVOID->void*
        [DllImport("ole32.dll", EntryPoint="CoInitialize", CallingConvention=CallingConvention.StdCall)]
        public static extern  int CoInitialize(int pvReserved) ;

        
        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpLibFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint="LoadLibraryW")]
        public static extern  IntPtr LoadLibrary([In] [MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName) ;


        public delegate IntPtr PAttachControl([In] object iunk, IntPtr hWnd, [In] IntPtr piunk);
        /// Return Type: FARPROC
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpProcName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint="GetProcAddress")]
        public static extern  PAttachControl GetProcAddress([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpProcName) ;

    }
}
