using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace CoreWindowsWrapper.Api.Win32
{
    internal static class User32
    {
        /// Return Type: void
        ///param0: HWND->HWND__*
        ///param1: UINT->unsigned int
        ///param2: UINT_PTR->unsigned int
        ///param3: DWORD->unsigned int
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void Timerproc(IntPtr param0, uint param1, IntPtr param2, uint param3);


        /// Return Type: UINT_PTR->unsigned int
        ///hWnd: HWND->HWND__*
        ///nIDEvent: UINT_PTR->unsigned int
        ///uElapse: UINT->unsigned int
        ///lpTimerFunc: TIMERPROC
        [DllImport("user32.dll", EntryPoint = "SetTimer")]
        public static extern UIntPtr SetTimer([In] IntPtr hWnd, UIntPtr nIdEvent, uint uElapse,
            Timerproc lpTimerFunc);




        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///uIDEvent: UINT_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "KillTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool KillTimer([In] IntPtr hWnd, UIntPtr uIdEvent);


        [DllImport("user32.dll",EntryPoint ="UpdateWindow")]
        public static extern bool UpdateWindow(IntPtr hWnd);

        [DllImport("user32.dll",EntryPoint ="ShowWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll",EntryPoint ="DestroyWindow", SetLastError = true)]
        public static extern bool DestroyWindow(IntPtr hWnd);

        [DllImport("user32.dll",EntryPoint ="AppendMenu", CharSet = CharSet.Auto)]
        private static extern bool AppendMenu(IntPtr hMenu, MenuFlags uFlags, uint uIdNewItem, string lpNewItem);


        //public static IntPtr CreateWindowEx(
        //    int dwExStyle,
        //    string lpClassName,
        //    string lpWindowName,
        //    uint dwStyle,
        //    int x,
        //    int y,
        //    int nWidth,
        //    int nHeight,
        //    IntPtr hWndParent,
        //    IntPtr hMenu,
        //    IntPtr hInstance,
        //    IntPtr lpParam)
        //{

        //    return CreateWindowExW((uint)dwExStyle, lpClassName, lpWindowName, dwStyle, x, y, nWidth, nHeight, hWndParent,
        //        hMenu, hInstance, lpParam);
        //}

        [DllImport("user32.dll",EntryPoint = "CreateWindowEx", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateWindowEx(
            int dwExStyle,
            string lpClassName,
            string lpWindowName,
            uint dwStyle,
            int x,
            int y,
            int nWidth,
            int nHeight,
            IntPtr hWndParent,
            IntPtr hMenu,
            IntPtr hInstance,
            IntPtr lpParam);


        // Return Type: HWND->HWND__*
        //dwExStyle: DWORD->unsigned int
        //lpClassName: LPCSTR->CHAR*
        //lpWindowName: LPCSTR->CHAR*
        //dwStyle: DWORD->unsigned int
        //X: int
        //Y: int
        //nWidth: int
        //nHeight: int
        //hWndParent: HWND->HWND__*
        //hMenu: HMENU->HMENU__*
        //hInstance: HINSTANCE->HINSTANCE__*
        //lpParam: LPVOID->void*
        //[DllImport("user32.dll", EntryPoint = "CreateWindowExA")]
        //public static extern IntPtr CreateWindowExA(uint dwExStyle,
        //    [In, MarshalAs(UnmanagedType.LPStr)] 
        //    string lpClassName, [In, MarshalAs(UnmanagedType.LPStr)]  string lpWindowName, uint dwStyle, int X, int Y, int nWidth, int nHeight, [In] IntPtr hWndParent,
        //    [In] IntPtr hMenu, [In] IntPtr hInstance, [In] IntPtr lpParam);


        // Return Type: HWND->HWND__*
        //dwExStyle: DWORD->unsigned int
        //lpClassName: LPCWSTR->WCHAR*
        //lpWindowName: LPCWSTR->WCHAR*
        //dwStyle: DWORD->unsigned int
        //X: int
        //Y: int
        //nWidth: int
        //nHeight: int
        //hWndParent: HWND->HWND__*
        //hMenu: HMENU->HMENU__*
        //hInstance: HINSTANCE->HINSTANCE__*
        //lpParam: LPVOID->void*
        //[DllImport("user32.dll",SetLastError = true, EntryPoint="CreateWindowExW")]
        //public static extern IntPtr CreateWindowExW(uint dwExStyle,
        //    [In, MarshalAs(UnmanagedType.LPWStr)]
        //    string lpClassName, [In, MarshalAs(UnmanagedType.LPWStr)]  string lpWindowName, uint dwStyle, int X, int Y, int nWidth, int nHeight, [In] IntPtr hWndParent,
        //    [In] IntPtr hMenu, [In] IntPtr hInstance, [In] IntPtr lpParam);



        /// Return Type: ATOM->WORD->unsigned short
        ///param0: WNDCLASSEXA*
        [DllImport("user32.dll",EntryPoint ="RegisterClassEx", CharSet = CharSet.Auto)]
        public static extern ushort RegisterClassEx([In()] ref WndclassEx param0);


        //public static ushort RegisterClassEx([In] ref Wndclassex lpWndClass)
        //{
        //    return RegisterClassExA(ref lpWndClass);
        //}

        ///// Return Type: ATOM->WORD->unsigned short
        /////param0: WNDCLASSEXW*
        //[DllImport("user32.dll", EntryPoint="RegisterClassExW")]
        //public static extern  ushort RegisterClassExW([In] ref Wndclassex param0) ;



        [DllImport("user32.dll",EntryPoint ="UnregisterClass",CharSet =CharSet.Auto)]
        public static extern bool UnregisterClass(string lpClassName, IntPtr hInstance);



        [DllImport("user32.dll",EntryPoint ="DefWindowProc",CharSet =CharSet.Auto)]
        public static extern IntPtr DefWindowProc(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll",EntryPoint ="PostQuitMessage")]
        public static extern void PostQuitMessage(int nExitCode);

        [DllImport("user32.dll",EntryPoint ="GetMessage",CharSet =CharSet.Auto)]
        public static extern sbyte GetMessage(out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin,
            uint wMsgFilterMax);



        [DllImport("user32.dll", EntryPoint = "GetClassName", CharSet = CharSet.Auto)]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder buf, int nMaxCount);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpClassName: LPSTR->CHAR*
        ///nMaxCount: int
        //[DllImport("user32.dll", EntryPoint = "GetClassNameA")]
        //public static extern int GetClassNameA([In] IntPtr hWnd,
        //    [Out, MarshalAs(UnmanagedType.LPStr)]  StringBuilder lpClassName, int nMaxCount);


        public static string GetClassName(IntPtr hWnd)
        {
            StringBuilder sb = new StringBuilder(256);
            int retValue = GetClassName(hWnd, sb, 256);
            return sb.ToString();
        }


        /// Return Type: BOOL->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpszClass: LPCSTR->CHAR*
        ///lpwcx: LPWNDCLASSEXA->tagWNDCLASSEXA*
        [DllImport("user32.dll", EntryPoint = "GetClassInfoEx",CallingConvention =CallingConvention.StdCall, CharSet= CharSet.Auto, SetLastError= true,ThrowOnUnmappableChar = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClassInfoExA([In()] IntPtr hInstance, [In()]string lpszClass, ref WndclassEx lpwcx);

        ///// Return Type: BOOL->int
        /////hInstance: HINSTANCE->HINSTANCE__*
        /////lpszClass: LPCWSTR->WCHAR*
        /////lpwcx: LPWNDCLASSEXW->tagWNDCLASSEXW*
        //[DllImport("user32.dll", EntryPoint = "GetClassInfoExW", CharSet = CharSet.Ansi)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //public static extern bool GetClassInfoExW([In] IntPtr hInstance, [In] string lpszClass, ref Wndclassex lpwcx);


       

        [DllImport("user32.dll",EntryPoint ="LoadCursor",CharSet =CharSet.Auto)]
        public static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);

        /// Return Type: HANDLE->void*
        ///hInst: HINSTANCE->HINSTANCE__*
        ///name: LPCWSTR->WCHAR*
        ///type: UINT->unsigned int
        ///cx: int
        ///cy: int
        ///fuLoad: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "LoadImage",CharSet =CharSet.Auto)]
        public static extern IntPtr LoadImage([In] IntPtr hInst, [In] string name, uint type, int cx, int cy, uint fuLoad);

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        ///bRepaint: BOOL->int
        [DllImport("user32.dll", EntryPoint = "MoveWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveWindow([In] IntPtr hWnd, int X, int Y, int nWidth, int nHeight,
            [MarshalAs(UnmanagedType.Bool)] bool bRepaint);



        /// Return Type: HWND->HWND__*
        ///hWndChild: HWND->HWND__*
        ///hWndNewParent: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "SetParent")]
        public static extern IntPtr SetParent([In] IntPtr hWndChild, [In] IntPtr hWndNewParent);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsWindowEnabled")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowEnabled([In] IntPtr hWnd);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///bEnable: BOOL->int
        [DllImport("user32.dll", EntryPoint = "EnableWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnableWindow([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bEnable);


        [DllImport("user32.dll",EntryPoint ="TranslateMessage")]
        public static extern bool TranslateMessage([In] ref MSG lpMsg);

        [DllImport("user32.dll",EntryPoint ="DispatchMessage",CharSet =CharSet.Auto, SetLastError = true)]
        public static extern IntPtr DispatchMessage([In] ref MSG lpmsg);

        //[DllImport("user32.dll", CharSet = CharSet.Auto)]
        //public static extern IntPtr DefWindowProc(
        //    IntPtr hWnd,
        //    int msg,
        //    IntPtr wParam,
        //    IntPtr lParam);


        [DllImport("user32.dll",EntryPoint = "CallWindowProc", CharSet = CharSet.Auto)]
        public static extern IntPtr CallWindowProc(
            IntPtr wndProc,
            IntPtr hWnd,
            int msg,
            IntPtr wParam,
            IntPtr lParam);


        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool SetWindowTextO(IntPtr hwnd, String lpString);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "SetWindowText", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowText([In] IntPtr hWnd,
            [In] string lpString);


        [DllImport("user32.dll",EntryPoint ="MessageBoxEx",CharSet =CharSet.Auto)]
        public static extern int MessageBoxEx(IntPtr hWnd, string lpText, string lpCaption,
            uint uType, ushort wLanguageId);

        [DllImport("user32.dll",EntryPoint ="MessageBox", SetLastError = true,CharSet =CharSet.Auto)]
        public static extern uint MessageBox(IntPtr hwnd,
            string text,
            string title,
            uint type);





        /// Return Type: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "CreateMenu")]
        public static extern IntPtr CreateMenu();

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "AppendMenu", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AppendMenu([In] IntPtr hMenu, uint uFlags, uint uIDNewItem,
            [In] string lpNewItem);

        [DllImport("user32.dll", EntryPoint = "AppendMenu", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AppendMenu([In] IntPtr hMenu, IntPtr uFlags, uint uIDNewItem,
            [In] string lpNewItem);

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "InsertMenu",CharSet =CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InsertMenu([In] IntPtr hMenu, uint uPosition, uint uFlags, uint uIDNewItem,
            [In] string lpNewItem);

        /// Return Type: HMENU->HMENU__*
        ///lpMenuTemplate: MENUTEMPLATEW*
        [DllImport("user32.dll", EntryPoint = "LoadMenuIndirect",CharSet =CharSet.Auto)]
        public static extern IntPtr LoadMenuIndirect([In] IntPtr lpMenuTemplate);




        /// Return Type: HMENU->HMENU__*
        ///hMenu: HMENU->HMENU__*
        ///nPos: int
        [DllImport("user32.dll", EntryPoint = "GetSubMenu")]
        public static extern IntPtr GetSubMenu([In] IntPtr hMenu, int nPos);

        /// Return Type: UINT->unsigned int
        ///hMenu: HMENU->HMENU__*
        ///nPos: int
        [DllImport("user32.dll", EntryPoint = "GetMenuItemID")]
        public static extern uint GetMenuItemID([In] IntPtr hMenu, int nPos);


        /// Return Type: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "CreatePopupMenu")]
        public static extern IntPtr CreatePopupMenu();





        /// Return Type: BOOL->int
        ///uiAction: UINT->unsigned int
        ///uiParam: UINT->unsigned int
        ///pvParam: PVOID->void*
        ///fWinIni: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfoW(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);

        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfo(uint uiAction, int uiParam, ref LogFont logFont, int fWinIni);


        public static bool GetDefaultLogFont(out LogFont logFont)
        {
            LogFont lFont = new LogFont();

            int size = Marshal.SizeOf(typeof(LogFont));
            bool retVal = SystemParametersInfo(SpiConst.SPI_GETICONTITLELOGFONT, size, ref lFont, 0);
            logFont = lFont;
            return retVal;
        }


        [DllImport("user32.dll", EntryPoint = "GetDC", SetLastError = true)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "ReleaseDC", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32.dll")]
        public static extern int GetDlgCtrlID(IntPtr hwndCtl);

        // ReSharper disable once InconsistentNaming

        


        public static void SetWindowTextsRaw(IntPtr hWnd, string text)
        {
            IntPtr txt = Marshal.StringToCoTaskMemUni(text);
            SendMessage(hWnd, (int)WindowsMessages.WM_SETTEXT, (int)IntPtr.Zero, txt);
            Marshal.FreeCoTaskMem(txt);
        }

        public static string GetWindowTextRaw(IntPtr hwnd)
        {
            // Allocate correct string length first
            int length = (int)SendMessage(hwnd, (int)WindowsMessages.WM_GETTEXTLENGTH, (int)IntPtr.Zero,
                IntPtr.Zero);
            StringBuilder sb = new StringBuilder(length + 1);
            SendMessage(hwnd, (int)WindowsMessages.WM_GETTEXT, (IntPtr)sb.Capacity, sb);
            return sb.ToString();
        }

        //[DllImport(dllName:"user32.dll", EntryPoint = "MessageBoxW", SetLastError=true, CharSet = CharSet.Unicode)]
        //public static extern int MessageBox(IntPtr hWnd, [MarshalAs(UnmanagedType.LPTStr)] string text, [MarshalAs(UnmanagedType.LPTStr)] string caption, uint options);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetActiveWindow();



        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, [Out] out uint lpdwProcessId);




        [DllImport("user32.dll", EntryPoint = "GetWindowLong", CharSet =CharSet.Auto)]
        private static extern IntPtr GetWindowLongPtr32(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr", CharSet =CharSet.Auto)]
        private static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, int nIndex);



        public static IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex)
        {
            bool is64 = IntPtr.Size == 8;

            if (is64)
                return GetWindowLongPtr64(hWnd, nIndex);
            else
                return GetWindowLongPtr32(hWnd, nIndex);
            
        }

        public static IntPtr GetWindowLongPtr(IntPtr hWnd, GWL gwl)
        {
            int index = (int)gwl;
            return GetWindowLongPtr(hWnd, index);
        }


        [DllImport("user32.dll", EntryPoint = "SetWindowLong", CharSet = CharSet.Auto)]
        public static extern int SetWindowLongPrt32([In] IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr", CharSet = CharSet.Auto)]
        private static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        public static IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr dwNewLong)
        {
            if (IntPtr.Size == 8)
                return SetWindowLongPtr64(hWnd, nIndex, dwNewLong);

            return new IntPtr(SetWindowLongPrt32(hWnd, nIndex, dwNewLong.ToInt32()));
        }

        public static IntPtr SetWindowLongPtr(IntPtr hWnd, GWL gwl, IntPtr dwNewLong)
        {
            int index = (int)gwl;
            return SetWindowLongPtr(hWnd, index, dwNewLong);
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetWindowRect(IntPtr hwnd, out Rect lpRect);



        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("User32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy,
            uint uFlags);

        [DllImport("User32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy,
            SetWindowPosFlags uFlags);


        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(SystemMetric smIndex);

        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int smIndex);


        [DllImport("user32.dll")]
        public static extern IntPtr BeginPaint(IntPtr hwnd, out Paintstruct lpPaint);

        [DllImport("user32.dll")]
        public static extern bool EndPaint(IntPtr hWnd, [In] ref Paintstruct lpPaint);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, StringBuilder lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, StringBuilder lParam);


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam,
             string lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam,
             string lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, ref IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, uint wParam = 0, uint lParam = 0);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, out HighLow lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, HighLow lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "SetMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenu([In] IntPtr hWnd, [In] IntPtr hMenu);


        /// Return Type: UINT->unsigned int
        ///hDlg: HWND->HWND__*
        ///nIDButton: int
        [DllImport("user32.dll", EntryPoint = "IsDlgButtonChecked")]
        public static extern uint IsDlgButtonChecked([In] IntPtr hDlg, int nIDButton);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpRect: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "GetClientRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClientRect([In] IntPtr hWnd, [Out] out Rect lpRect);


        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///nIDButton: int
        ///uCheck: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "CheckDlgButton")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckDlgButton([In] IntPtr hDlg, int nIDButton, uint uCheck);


        

       



        /// Return Type: BOOL->int
        ///hwndCombo: HWND->HWND__*
        ///pcbi: PCOMBOBOXINFO->tagCOMBOBOXINFO*
        [DllImport("user32.dll", EntryPoint = "GetComboBoxInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComboBoxInfo([In] IntPtr hwndCombo, ref COMBOBOXINFO pcbi);



      




  







        /// Return Type: INT_PTR->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///hDialogTemplate: LPCDLGTEMPLATEW->DLGTEMPLATE*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DialogBoxIndirectParamW")]
        public static extern int DialogBoxIndirectParam([In] IntPtr hInstance, [In] ref DialogTemplate hDialogTemplate, [In] IntPtr hWndParent, DLGPROC lpDialogFunc, [MarshalAs(UnmanagedType.SysInt)] int dwInitParam);




      


        /// Return Type: INT_PTR->int
        ///param0: HWND->HWND__*
        ///param1: UINT->unsigned int
        ///param2: WPARAM->UINT_PTR->unsigned int
        ///param3: LPARAM->LONG_PTR->int
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int DLGPROC(IntPtr hWnd, uint param1, IntPtr wParam, IntPtr lParam);

        public static void AddTbButton(IntPtr tbHandle, string name, int idCommand)
        {
            int btnStuctSiez = Marshal.SizeOf(typeof(TBBUTTON));
            SendMessage(tbHandle, 0x41E, new IntPtr(btnStuctSiez), IntPtr.Zero);
            TBBUTTON btnStruct = new TBBUTTON();
            btnStruct.fsState = 0x4;
            btnStruct.idCommand = idCommand;
            btnStruct.iString = SendMessage(tbHandle, 0x44D, 0, name + '\0');
            //btnStruct.fsStyle = 0x2;
            IntPtr btnStructState = IntPtr.Zero;
            try
            {
                btnStructState = Marshal.AllocHGlobal(btnStuctSiez);
                Marshal.StructureToPtr(btnStruct, btnStructState, true);
                SendMessage(tbHandle, 0x444, new IntPtr(1), btnStructState);

            }
            finally
            {
                if (btnStructState != IntPtr.Zero) Marshal.FreeHGlobal(btnStructState);
            }



        }







        public static uint EnableVisualStyles()
        {
            string dir = System.Reflection.Assembly.GetExecutingAssembly().Location; ;

            ACTCTX actCtx = new ACTCTX()
            {
                cbSize = Marshal.SizeOf(typeof(ACTCTX)),
                dwFlags = ACTCX_FALGS.ACTCTX_FLAG_RESOURCE_NAME_VALID,
                lpSource = dir,
                wLangId = 0,
                lpResourceName = new IntPtr(101)

            };

            IntPtr hActCtx = Kernel32.CreateActCtx(ref actCtx);
            bool contextCreationSucceeded = (hActCtx != new IntPtr(-1));

            if (!contextCreationSucceeded)
            {
                actCtx.lpResourceName = (IntPtr)ACTCX_FALGS.ISOLATIONAWARE_NOSTATICIMPORT_MANIFEST_RESOURCE_ID;
                hActCtx = Kernel32.CreateActCtx(ref actCtx);
                contextCreationSucceeded = (hActCtx != new IntPtr(-1));
            }

            if (!contextCreationSucceeded)
            {
                actCtx.lpResourceName = (IntPtr)ACTCX_FALGS.CREATEPROCESS_MANIFEST_RESOURCE_ID;
                hActCtx = Kernel32.CreateActCtx(ref actCtx);
                contextCreationSucceeded = (hActCtx != new IntPtr(-1));
            }

            Kernel32.ActivateActCtx(hActCtx, out var ulpActivationCookie);
            return ulpActivationCookie;
        }





        /// Return Type: void
        ///hWinEventHook: HWINEVENTHOOK->HWINEVENTHOOK__*
        ///event: DWORD->unsigned int
        ///hwnd: HWND->HWND__*
        ///idObject: LONG->int
        ///idChild: LONG->int
        ///idEventThread: DWORD->unsigned int
        ///dwmsEventTime: DWORD->unsigned int
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void WinEventProc(IntPtr hWinEventHook, uint @event, IntPtr hwnd, int idObject, int idChild, uint idEventThread, uint dwmsEventTime);


        /// Return Type: HWINEVENTHOOK->HWINEVENTHOOK__*
        ///eventMin: DWORD->unsigned int
        ///eventMax: DWORD->unsigned int
        ///hmodWinEventProc: HMODULE->HINSTANCE->HINSTANCE__*
        ///pfnWinEventProc: WINEVENTPROC
        ///idProcess: DWORD->unsigned int
        ///idThread: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetWinEventHook")]
        public static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, [In] IntPtr hmodWinEventProc, WinEventProc pfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

        public static IntPtr HookWindowEvent(WinEventProc pfnWinEventProc, uint processId, uint threadId)
        {
            return SetWinEventHook(EVENT_MIN, EVENT_MAX, IntPtr.Zero, pfnWinEventProc, processId, threadId,
                WINEVENT_OUTOFCONTEXT | WINEVENT_SKIPOWNPROCESS);
        }

        /// Return Type: BOOL->int
        ///hWinEventHook: HWINEVENTHOOK->HWINEVENTHOOK__*
        [DllImport("user32.dll", EntryPoint = "UnhookWinEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWinEvent([In] IntPtr hWinEventHook);


        private const uint EVENT_MIN = 0x00000001;
        private const uint EVENT_MAX = 0x7FFFFFFF;


        /// WINEVENT_SKIPOWNPROCESS -> 0x0002
        private const uint WINEVENT_SKIPOWNPROCESS = 0x0002;

        /// WINEVENT_SKIPOWNTHREAD -> 0x0001
        private const uint WINEVENT_SKIPOWNTHREAD = 0x0001;

        /// WINEVENT_OUTOFCONTEXT -> 0x0000
        private const uint WINEVENT_OUTOFCONTEXT = 0x0000;

        /// WINEVENT_INCONTEXT -> 0x0004
        private const uint WINEVENT_INCONTEXT = 0x0004;

        public static bool GetClassInfoEx(IntPtr instanceHandle, string className, out WndclassEx wndclassex)
        {
            WndclassEx wnd = new WndclassEx();
            wnd.cbSize = Marshal.SizeOf(typeof(WndclassEx));
            bool val = false;
            try
            {
                //val = GetClassInfoExW(instanceHandle, className,ref wnd);
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);

            }
            
            wndclassex = new WndclassEx();
            if (val)
            {
                wndclassex.cbClsExtra = wnd.cbClsExtra;
                wndclassex.cbSize = (int) wnd.cbSize;
                wndclassex.cbWndExtra = wnd.cbWndExtra;
                wndclassex.hbrBackground = wnd.hbrBackground;
                wndclassex.hCursor = wnd.hCursor;
                wndclassex.hIcon = wnd.hIcon;
                wndclassex.hIconSm = wnd.hIconSm;
                wndclassex.hInstance = wnd.hInstance;
                wndclassex.lpfnWndProc = wnd.lpfnWndProc;
                wndclassex.lpszClassName = wnd.lpszClassName;
                wndclassex.lpszMenuName = wnd.lpszMenuName;
                wndclassex.style = wnd.style;

            }


            return val;
        }
    }
}