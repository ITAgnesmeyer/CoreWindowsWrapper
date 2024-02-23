using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{

    public class NativeRichTextBox : NativeControlBase
    {

        internal const int INPUT = 0x0001;
        internal const int OUTPUT = 0x0002;
        internal const int DIRECTIONMASK = INPUT | OUTPUT;

        private const uint SF_RTF = 0x0002;

        /// GENERIC_READ -> (0x80000000L)
        private const uint GENERIC_READ = 0x80000000;
        
        /// OPEN_EXISTING -> 3
        private const int OPEN_EXISTING = 3;

        /// FILE_FLAG_SEQUENTIAL_SCAN -> 0x08000000
        private const int FILE_FLAG_SEQUENTIAL_SCAN = 134217728;

        /// FILE_SHARE_READ -> 0x00000001
        private const int FILE_SHARE_READ = 1;

        /// FILE_GENERIC_READ -> (STANDARD_RIGHTS_READ     |                                   FILE_READ_DATA           |                                   FILE_READ_ATTRIBUTES     |                                   FILE_READ_EA             |                                   SYNCHRONIZE)
        private const int FILE_GENERIC_READ = (STANDARD_RIGHTS_READ 
                                              | (FILE_READ_DATA 
                                                 | (FILE_READ_ATTRIBUTES 
                                                    | (FILE_READ_EA | SYNCHRONIZE))));
    
        /// STANDARD_RIGHTS_READ -> (READ_CONTROL)
        private const int STANDARD_RIGHTS_READ = READ_CONTROL;
    
        /// FILE_READ_DATA -> ( 0x0001 )
        private const int FILE_READ_DATA = 1;
    
        /// FILE_READ_ATTRIBUTES -> ( 0x0080 )
        private const int FILE_READ_ATTRIBUTES = 128;
    
        /// FILE_READ_EA -> ( 0x0008 )
        private const int FILE_READ_EA = 8;
    
        /// SYNCHRONIZE -> (0x00100000L)
        private const int SYNCHRONIZE = 1048576;
    
        /// READ_CONTROL -> (0x00020000L)
        private const int READ_CONTROL = 131072;


     
        public delegate int EDITSTREAMCALLBACK(IntPtr dwCookie, IntPtr pbBuff, int cb, out int pcb);

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct EDITSTREAM
        {
            public UIntPtr dwCookie;
            public uint dwError;
            public IntPtr pfnCallback;
        }

      
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        private struct OVERLAPPED {
    
            /// ULONG_PTR->unsigned int
            public uint Internal;
    
            /// ULONG_PTR->unsigned int
            public uint InternalHigh;
    
            /// Anonymous_7416d31a_1ce9_4e50_b1e1_0f2ad25c0196
            public Anonymous_7416d31a_1ce9_4e50_b1e1_0f2ad25c0196 Union1;
    
            /// HANDLE->void*
            public System.IntPtr hEvent;
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        private struct Anonymous_7416d31a_1ce9_4e50_b1e1_0f2ad25c0196 {
    
            /// Anonymous_ac6e4301_4438_458f_96dd_e86faeeca2a6
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public Anonymous_ac6e4301_4438_458f_96dd_e86faeeca2a6 Struct1;
    
            /// PVOID->void*
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public System.IntPtr Pointer;
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        private struct Anonymous_ac6e4301_4438_458f_96dd_e86faeeca2a6 {
    
            /// DWORD->unsigned int
            public uint Offset;
    
            /// DWORD->unsigned int
            public uint OffsetHigh;
        }

        
        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpBuffer: LPVOID->void*
        ///nNumberOfBytesToRead: DWORD->unsigned int
        ///lpNumberOfBytesRead: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint="ReadFile")]
        [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
        private static extern  bool ReadFile([System.Runtime.InteropServices.InAttribute()] System.IntPtr hFile, System.IntPtr lpBuffer, uint nNumberOfBytesToRead, System.IntPtr lpNumberOfBytesRead, System.IntPtr lpOverlapped) ;

        /// Return Type: HANDLE->void*
        ///lpFileName: LPCWSTR->WCHAR*
        ///dwDesiredAccess: DWORD->unsigned int
        ///dwShareMode: DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///dwCreationDisposition: DWORD->unsigned int
        ///dwFlagsAndAttributes: DWORD->unsigned int
        ///hTemplateFile: HANDLE->void*
        [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint="CreateFileW")]
        private static extern  System.IntPtr CreateFileW([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lpFileName, uint dwDesiredAccess, uint dwShareMode, [System.Runtime.InteropServices.InAttribute()] System.IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, [System.Runtime.InteropServices.InAttribute()] System.IntPtr hTemplateFile) ;

        /// Return Type: BOOL->int
        ///hObject: HANDLE->void*
        [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint="CloseHandle")]
        [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
        private static extern  bool CloseHandle([System.Runtime.InteropServices.InAttribute()] System.IntPtr hObject) ;



        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint="SendMessageW")]
        private static extern  IntPtr SendMessageW([System.Runtime.InteropServices.InAttribute()] System.IntPtr hWnd, uint Msg, int wParam,ref EDITSTREAM lParam) ;


        private string _Text;
        private const uint EM_SETTEXTEX = (WindowsMessages.WM_USER + 97);
        //#define ES_SAVESEL				0x00008000
        private const uint ES_SAVESEL = 0x00008000;
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        private struct SETTEXTEX
        {

            /// DWORD->unsigned int
            public uint flags;

            /// UINT->unsigned int
            public uint codepage;
        }

        protected override void Initialize()
        {
            Kernel32.LoadLibrary("Msftedit.dll");
            //Kernel32.LoadLibrary("C:\\Program Files\\Microsoft Office\\root\\vfs\\ProgramFilesCommonX64\\Microsoft Shared\\Office16\\riched20.dll");
            base.Initialize();
            //this.TypeIdentifier = "RICHEDIT60W";//"RICHEDIT50W";
            this.TypeIdentifier = "RICHEDIT50W";
            this.Style = this.Style | EditBoxStyles.ES_MULTILINE | ES_SAVESEL | EditBoxStyles.ES_WANTRETURN  | WindowStylesConst.WS_HSCROLL | WindowStylesConst.WS_VSCROLL;

        }

        //public void Load(string filePath)
        //{
        //    Stream file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        //    try
        //    {
        //        this.editStream = file;
        //        var es = default(EDITSTREAM);
        //        es.dwCookie = (UIntPtr)SF_RTF;
        //        var callback = new EDITSTREAMCALLBACK(EditStreamCallback);

        //        es.pfnCallback = Marshal.GetFunctionPointerForDelegate(callback);

        //        SendMessageW(this.Handle, RichEditMessages.EM_STREAMIN, (int)SF_RTF, ref es);
        //        GC.KeepAlive(callback);
        //    }
        //    finally
        //    {
        //        file.Close();
        //    }
        //}

        //private void StreamIn(Stream data)
        //{
        //    try
        //    {
        //        this.editStream = data;

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
        //}

        //private Stream editStream;
        //private int EditStreamCallback(IntPtr dwcookie, IntPtr pbbuff, int cb, out int pcb)
        //{
           
        //}

        //private IntPtr EditStreamCallback(IntPtr dwCookie, IntPtr pbBuff, IntPtr cb, IntPtr pcb)
        //{
        //    int result = -1;
            
        //    if (ReadFile(dwCookie, pbBuff, (uint)cb, pcb, IntPtr.Zero))
        //    {
        //        result = 0;
        //    }

           
            
        //    return new IntPtr(result);
        //}

        public override string Text
        {
            get
            {
                if (this.Handle != IntPtr.Zero)
                {
                    IntPtr size = User32.SendMessage(this.Handle, WindowsMessages.WM_GETTEXTLENGTH, 0, 0);
                    int len = size.ToInt32();
                    StringBuilder sb = new StringBuilder(len + 1);
                    User32.SendMessage(this.Handle, (int)WindowsMessages.WM_GETTEXT, sb.Capacity, sb);
                    this._Text = sb.ToString();
                }
                return this._Text;
            }
            set
            {
                this._Text = value;
                if (this.Handle != IntPtr.Zero)
                {
                    SETTEXTEX stx = new SETTEXTEX
                    {
                        codepage = 1200,
                        flags = 0
                    };
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf<SETTEXTEX>());
                    Marshal.StructureToPtr(stx, ptr, false);
                    User32.SendMessage(this.Handle, (int)EM_SETTEXTEX, ptr, this._Text);
                    Marshal.FreeHGlobal(ptr);
                }
            }
        }

        public override bool Create(IntPtr parentId)
        {
            bool retVal = base.Create(parentId);
            //User32.SendMessage(this.Handle, RichEditMessages.EM_EXLIMITTEXT, 0, uint.MaxValue);
            User32.SendMessage(this.Handle, (int)RichEditMessages.EM_SETTEXTMODE, 2, IntPtr.Zero);
            return retVal;

        }
    }
}