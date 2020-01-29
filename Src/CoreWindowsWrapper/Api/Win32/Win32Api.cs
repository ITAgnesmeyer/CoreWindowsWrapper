using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

namespace CoreWindowsWrapper.Api.Win32
{
    internal static class Win32Api
    {
        /// Return Type: void
        ///param0: HWND->HWND__*
        ///param1: UINT->unsigned int
        ///param2: UINT_PTR->unsigned int
        ///param3: DWORD->unsigned int
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void TIMERPROC(IntPtr param0, uint param1, IntPtr param2, uint param3);


        /// Return Type: UINT_PTR->unsigned int
        ///hWnd: HWND->HWND__*
        ///nIDEvent: UINT_PTR->unsigned int
        ///uElapse: UINT->unsigned int
        ///lpTimerFunc: TIMERPROC
        [DllImport("user32.dll", EntryPoint = "SetTimer")]
        public static extern UIntPtr SetTimer([In] IntPtr hWnd, UIntPtr nIDEvent, uint uElapse,
            TIMERPROC lpTimerFunc);

        


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///uIDEvent: UINT_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "KillTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool KillTimer([In] IntPtr hWnd, UIntPtr uIDEvent);


        [DllImport("user32.dll")]
        public static extern bool UpdateWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool DestroyWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool AppendMenu(IntPtr hMenu, MenuFlags uFlags, uint uIDNewItem, string lpNewItem);


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

        [DllImport("user32.dll", SetLastError=true, CharSet= CharSet.Ansi)]
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


        /// Return Type: HWND->HWND__*
        ///dwExStyle: DWORD->unsigned int
        ///lpClassName: LPCSTR->CHAR*
        ///lpWindowName: LPCSTR->CHAR*
        ///dwStyle: DWORD->unsigned int
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        ///hWndParent: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpParam: LPVOID->void*
        //[DllImport("user32.dll", EntryPoint = "CreateWindowExA")]
        //public static extern IntPtr CreateWindowExA(uint dwExStyle,
        //    [In, MarshalAs(UnmanagedType.LPStr)] 
        //    string lpClassName, [In, MarshalAs(UnmanagedType.LPStr)]  string lpWindowName, uint dwStyle, int X, int Y, int nWidth, int nHeight, [In] IntPtr hWndParent,
        //    [In] IntPtr hMenu, [In] IntPtr hInstance, [In] IntPtr lpParam);


        /// Return Type: HWND->HWND__*
        ///dwExStyle: DWORD->unsigned int
        ///lpClassName: LPCWSTR->WCHAR*
        ///lpWindowName: LPCWSTR->WCHAR*
        ///dwStyle: DWORD->unsigned int
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        ///hWndParent: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpParam: LPVOID->void*
        //[DllImport("user32.dll",SetLastError = true, EntryPoint="CreateWindowExW")]
        //public static extern IntPtr CreateWindowExW(uint dwExStyle,
        //    [In, MarshalAs(UnmanagedType.LPWStr)]
        //    string lpClassName, [In, MarshalAs(UnmanagedType.LPWStr)]  string lpWindowName, uint dwStyle, int X, int Y, int nWidth, int nHeight, [In] IntPtr hWndParent,
        //    [In] IntPtr hMenu, [In] IntPtr hInstance, [In] IntPtr lpParam);


        
        /// Return Type: ATOM->WORD->unsigned short
        ///param0: WNDCLASSEXA*
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", CharSet = CharSet.Ansi)]
        public static extern  ushort RegisterClassEx([System.Runtime.InteropServices.InAttribute()] ref Wndclassex param0) ;


        //public static ushort RegisterClassEx([In] ref Wndclassex lpWndClass)
        //{
        //    return RegisterClassExA(ref lpWndClass);
        //}

        ///// Return Type: ATOM->WORD->unsigned short
        /////param0: WNDCLASSEXW*
        //[DllImport("user32.dll", EntryPoint="RegisterClassExW")]
        //public static extern  ushort RegisterClassExW([In] ref Wndclassex param0) ;



        [DllImport("user32.dll")]
        public static extern bool UnregisterClass(string lpClassName, IntPtr hInstance);

        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

        [DllImport("user32.dll")]
        public static extern IntPtr DefWindowProc(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern void PostQuitMessage(int nExitCode);

        [DllImport("user32.dll")]
        public static extern sbyte GetMessage(out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin,
            uint wMsgFilterMax);

        
       
        [DllImport("user32.dll", EntryPoint="GetClassName", CharSet= CharSet.Ansi)]
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
            int retValue = GetClassName(hWnd, sb, sb.Length);
            return sb.ToString();
        }


        ///// Return Type: BOOL->int
        /////hInstance: HINSTANCE->HINSTANCE__*
        /////lpszClass: LPCSTR->CHAR*
        /////lpwcx: LPWNDCLASSEXA->tagWNDCLASSEXA*
        //[System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint="GetClassInfoExA")]
        //[return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
        //public static extern  bool GetClassInfoExA([System.Runtime.InteropServices.InAttribute()] System.IntPtr hInstance, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string lpszClass, ref WndclassexA lpwcx) ;

        /// Return Type: BOOL->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpszClass: LPCWSTR->WCHAR*
        ///lpwcx: LPWNDCLASSEXW->tagWNDCLASSEXW*
        [DllImport("user32.dll", EntryPoint="GetClassInfoEx", CharSet= CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool GetClassInfoExW([In] IntPtr hInstance, [In] string lpszClass,  ref Wndclassex lpwcx) ;

        
       

        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);

        /// Return Type: HANDLE->void*
        ///hInst: HINSTANCE->HINSTANCE__*
        ///name: LPCWSTR->WCHAR*
        ///type: UINT->unsigned int
        ///cx: int
        ///cy: int
        ///fuLoad: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "LoadImageW")]
        public static extern IntPtr LoadImage([In] IntPtr hInst, [In, MarshalAs(UnmanagedType.LPWStr)]  string name, uint type, int cx, int cy, uint fuLoad);

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
        [DllImport("user32.dll", EntryPoint="SetParent")]
        public static extern IntPtr SetParent([In] IntPtr hWndChild, [In] IntPtr hWndNewParent);

        
        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint="IsWindowEnabled")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool IsWindowEnabled([In] IntPtr hWnd) ;


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///bEnable: BOOL->int
        [DllImport("user32.dll", EntryPoint = "EnableWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnableWindow([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bEnable);


        [DllImport("user32.dll")]
        public static extern bool TranslateMessage([In] ref MSG lpMsg);

        [DllImport("user32.dll",SetLastError =true)]
        public static extern IntPtr DispatchMessage([In] ref MSG lpmsg);

        //[DllImport("user32.dll", CharSet = CharSet.Auto)]
        //public static extern IntPtr DefWindowProc(
        //    IntPtr hWnd,
        //    int msg,
        //    IntPtr wParam,
        //    IntPtr lParam);


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
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
        [DllImport("user32.dll", EntryPoint="SetWindowText", CharSet= CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowText([In] IntPtr hWnd,
            [In]  string lpString);


        [DllImport("user32.dll")]
        public static extern int MessageBoxEx(IntPtr hWnd, string lpText, string lpCaption,
            uint uType, ushort wLanguageId);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint MessageBox(IntPtr hwnd,
            string text,
            string title,
            uint type);


        [DllImport("gdi32.dll", EntryPoint = "CreateSolidBrush", SetLastError = true)]
        public static extern IntPtr CreateSolidBrush(int crColor);


        [DllImport("gdi32.dll", EntryPoint = "SetBkColor", SetLastError = true)]
        public static extern uint SetBkColor(IntPtr hdc, int crColor);

        [DllImport("gdi32.dll")]
        public static extern uint SetTextColor(IntPtr hdc, int crColor);


        /// Return Type: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint="CreateMenu")]
        public static extern  IntPtr CreateMenu() ;

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint="AppendMenu", CharSet= CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool AppendMenu([In] IntPtr hMenu, uint uFlags, uint uIDNewItem,
            [In]  string lpNewItem) ;

        [DllImport("user32.dll", EntryPoint="AppendMenu", CharSet= CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool AppendMenu([In] IntPtr hMenu, IntPtr uFlags, uint uIDNewItem,
            [In]  string lpNewItem) ;

        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint="InsertMenuW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool InsertMenu([In] IntPtr hMenu, uint uPosition, uint uFlags, uint uIDNewItem,
            [In, MarshalAs(UnmanagedType.LPWStr)]  string lpNewItem) ;

        /// Return Type: HMENU->HMENU__*
        ///lpMenuTemplate: MENUTEMPLATEW*
        [DllImport("user32.dll", EntryPoint="LoadMenuIndirectW")]
        public static extern  IntPtr LoadMenuIndirectW([In] IntPtr lpMenuTemplate) ;

        
        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpLibFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint="LoadLibraryW")]
        public static extern  IntPtr LoadLibrary([In, MarshalAs(UnmanagedType.LPWStr)]  string lpLibFileName) ;

        /// Return Type: HMENU->HMENU__*
        ///hMenu: HMENU->HMENU__*
        ///nPos: int
        [DllImport("user32.dll", EntryPoint="GetSubMenu")]
        public static extern  IntPtr GetSubMenu([In] IntPtr hMenu, int nPos) ;

        /// Return Type: UINT->unsigned int
        ///hMenu: HMENU->HMENU__*
        ///nPos: int
        [DllImport("user32.dll", EntryPoint="GetMenuItemID")]
        public static extern  uint GetMenuItemID([In] IntPtr hMenu, int nPos) ;

        
        /// Return Type: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint="CreatePopupMenu")]
        public static extern  IntPtr CreatePopupMenu() ;



        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///index: int
        [DllImport("gdi32.dll", EntryPoint = "GetDeviceCaps")]
        public static extern int GetDeviceCaps([In] IntPtr hdc, int index);

        /// Return Type: HFONT->HFONT__*
        ///lplf: LOGFONTW*
        [DllImport("gdi32.dll", EntryPoint = "CreateFontIndirectW")]
        public static extern IntPtr CreateFontIndirect([In] ref LogFont lplf);


        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetObject(IntPtr hObject, int nSize, [In, Out] LogFont lf);

        /// Return Type: int
        ///h: HANDLE->void*
        ///c: int
        ///pv: LPVOID->void*
        //[DllImport("gdi32.dll", EntryPoint = "GetObjectW")]
        //public static extern int GetObjectW([In] IntPtr h, int c, IntPtr pv);


        public static int GetObject(IntPtr hObject, LogFont lp)
        {
            return GetObject(hObject, Marshal.SizeOf(typeof(LogFont)), lp);
        }


        /// Return Type: BOOL->int
        ///uiAction: UINT->unsigned int
        ///uiParam: UINT->unsigned int
        ///pvParam: PVOID->void*
        ///fWinIni: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo", CharSet= CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfoW(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);

        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo", CharSet= CharSet.Ansi)]
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

        public static int RGB(int r, int g, int b) => checked(checked(checked(b * 65536) + checked(g * 256)) + r);


        public static void SetWindowTextsRaw(IntPtr hWnd, string text)
        {
            IntPtr txt = Marshal.StringToCoTaskMemUni(text);
            SendMessage(hWnd, (int) WindowsMessages.WM_SETTEXT, (int) IntPtr.Zero, txt);
            Marshal.FreeCoTaskMem(txt);
        }

        public static string GetWindowTextRaw(IntPtr hwnd)
        {
            // Allocate correct string length first
            int length = (int) SendMessage(hwnd, (int) WindowsMessages.WM_GETTEXTLENGTH, (int) IntPtr.Zero,
                IntPtr.Zero);
            StringBuilder sb = new StringBuilder(length + 1);
            SendMessage(hwnd, (int) WindowsMessages.WM_GETTEXT, (IntPtr) sb.Capacity, sb);
            return sb.ToString();
        }

        //[DllImport(dllName:"user32.dll", EntryPoint = "MessageBoxW", SetLastError=true, CharSet = CharSet.Unicode)]
        //public static extern int MessageBox(IntPtr hWnd, [MarshalAs(UnmanagedType.LPTStr)] string text, [MarshalAs(UnmanagedType.LPTStr)] string caption, uint options);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetActiveWindow();

        [DllImport("kernel32.dll")]
        public static extern ushort GetSystemDefaultLangID();

        [DllImport("user32.dll", SetLastError=true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, [Out] out uint lpdwProcessId);

        /// Return Type: DWORD->unsigned int
        ///Process: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint="GetProcessId")]
        public static extern  uint GetProcessId([In] IntPtr Process) ;


        [DllImport("user32.dll", EntryPoint="GetWindowLong", CharSet= CharSet.Ansi)]
        private static extern IntPtr GetWindowLongPtr32(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint="GetWindowLongPtr", CharSet= CharSet.Ansi)]
        private static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, int nIndex);



        public static IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex)
        {
            return IntPtr.Size == 8 ? 
                GetWindowLongPtr64(hWnd, nIndex) : 
                GetWindowLongPtr32(hWnd, nIndex);
        }

        public static IntPtr GetWindowLongPtr(IntPtr hWnd, GWL gwl)
        {
            int index = (int) gwl;
            return GetWindowLongPtr(hWnd, index);
        }

       
        [DllImport("user32.dll", EntryPoint="SetWindowLong", CharSet= CharSet.Ansi)]
        public static extern  int SetWindowLongPrt32([In] IntPtr hWnd, int nIndex, int dwNewLong) ;

        [DllImport("user32.dll", EntryPoint="SetWindowLongPtr", CharSet= CharSet.Ansi)]
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

        [DllImport("gdi32.dll")]
        public static extern IntPtr GetStockObject(StockObjects fnObject);

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
            [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam,
            [MarshalAs(UnmanagedType.LPWStr)] string lParam);

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
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr  lParam);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint="SetMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool SetMenu([In] IntPtr hWnd, [In] IntPtr hMenu) ;


        /// Return Type: UINT->unsigned int
        ///hDlg: HWND->HWND__*
        ///nIDButton: int
        [DllImport("user32.dll", EntryPoint = "IsDlgButtonChecked")]
        public static extern uint IsDlgButtonChecked([In] IntPtr hDlg, int nIDButton);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpRect: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint="GetClientRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool GetClientRect([In] IntPtr hWnd, [Out] out Rect lpRect) ;


        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///nIDButton: int
        ///uCheck: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "CheckDlgButton")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckDlgButton([In] IntPtr hDlg, int nIDButton, uint uCheck);


        ///pvReserved: LPVOID->void*
        [DllImport("ole32.dll", EntryPoint = "OleInitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleInitialize(IntPtr pvReserved);

        /// Return Type: void
        [DllImport("ole32.dll", EntryPoint = "OleUninitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern void OleUninitialize();


        [DllImport("comctl32.dll", EntryPoint = "InitCommonControlsEx", CallingConvention = CallingConvention.StdCall)]
        public static extern bool InitCommonControlsEx(ref INITCOMMONCONTROLSEX iccex);

        
        /// Return Type: HFILE->int
        ///lpFileName: LPCSTR->CHAR*
        ///lpReOpenBuff: LPOFSTRUCT->_OFSTRUCT*
        ///uStyle: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint="OpenFile")]
        public static extern  int OpenFile([In, MarshalAs(UnmanagedType.LPStr)]  string lpFileName, ref OFSTRUCT lpReOpenBuff, uint uStyle) ;

        
        /// Return Type: BOOL->int
        ///hwndCombo: HWND->HWND__*
        ///pcbi: PCOMBOBOXINFO->tagCOMBOBOXINFO*
        [DllImport("user32.dll", EntryPoint="GetComboBoxInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool GetComboBoxInfo([In] IntPtr hwndCombo, ref COMBOBOXINFO pcbi) ;


        public static int HiWord(int number)
        {
            if ((number & 0x80000000) == 0x80000000)
                return (number >> 16);
            else
                return (number >> 16) & 0xffff;
        }

        public static int LoWord(int number)
        {
            return number & 0xffff;
        }

        public static int MakeLong(int loWord, int hiWord)
        {
            return (hiWord << 16) | (loWord & 0xffff);
        }

        public static IntPtr MakeLParam(int loWord, int hiWord)
        {
            return (IntPtr) ((hiWord << 16) | (loWord & 0xffff));
        }

        public static int MulDiv(int number, int numerator, int denominator)
        {
            if (denominator == 0) return 0;
            return (int) ((long) number * numerator / denominator);
        }

        public static int MulDivReverse(int number, int numerator, int dimension)
        {
            if (numerator == 0) return 0;
            return (int) ((long) number * dimension / numerator);
        }

        public static byte BoolToByte(bool input)
        {
            if (input) return 1;
            return 0;
        }

        public static bool ByteToBool(byte input)
        {
            if (input == 1) return true;
            return false;
        }


        /// Return Type: BOOL->int
        ///param0: LPOPENFILENAMEW->tagOFNW*
        [DllImport("comdlg32.dll", EntryPoint="GetOpenFileNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool GetOpenFileName(ref OFNW param0) ;

        /// Return Type: BOOL->int
        ///param0: LPOPENFILENAMEW->tagOFNW*
        [DllImport("comdlg32.dll", EntryPoint="GetSaveFileNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool GetSaveFileName(ref OFNW param0) ;



        
        /// Return Type: void*
        ///cx: int
        ///cy: int
        ///flags: int
        ///cInitial: int
        ///cGrow: int
        [DllImport("Comctl32.dll", EntryPoint="ImageList_Create", CallingConvention=CallingConvention.StdCall)]
        public static extern  IntPtr ImageList_Create(int cx, int cy, int flags, int cInitial, int cGrow) ;

        /// Return Type: int
        ///himl: void*
        ///hbmImage: void*
        ///hbmMask: void*
        [DllImport("Comctl32.dll", EntryPoint="ImageList_Add", CallingConvention=CallingConvention.StdCall)]
        public static extern  int ImageList_Add(IntPtr himl, IntPtr hbmImage, IntPtr hbmMask) ;

        /// Return Type: int
        ///himl: void*
        [DllImport("Comctl32.dll", EntryPoint="ImageList_Destroy", CallingConvention=CallingConvention.StdCall)]
        public static extern  int ImageList_Destroy(IntPtr himl) ;




        
        [DllImport("kernel32.dll", EntryPoint = "CopyMemory", SetLastError = false)]
        public static extern void CopyMemory(IntPtr dest, IntPtr src, uint count);

            
        /// Return Type: int
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint="lstrlenW")]
        public static extern  int lstrlenW([In, MarshalAs(UnmanagedType.LPWStr)]  string lpString) ;

        /// Return Type: INT_PTR->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///hDialogTemplate: LPCDLGTEMPLATEW->DLGTEMPLATE*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint="DialogBoxIndirectParamW")]
        public static extern  int DialogBoxIndirectParam([In] IntPtr hInstance, [In] ref DialogTemplate hDialogTemplate, [In] IntPtr hWndParent, DLGPROC lpDialogFunc, [MarshalAs(UnmanagedType.SysInt)] int dwInitParam) ;




        /// Return Type: void
        ///dwFlags: DWORD->unsigned int
        [DllImport("UxTheme.dll", EntryPoint="SetThemeAppProperties")]
        public static extern  void SetThemeAppProperties(uint dwFlags) ;

        
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


        [DllImport("uxtheme.dll", ExactSpelling=true, CharSet=CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hWnd, String pszSubAppName, String pszSubIdList);

        public const int STAP_ALLOW_NONCLIENT    =  (1 << 0);
        public const int STAP_ALLOW_CONTROLS     =  (1 << 1);
        public const int STAP_ALLOW_WEBCONTENT   =  (1 << 2);
        public static void EnableTheme()
        {
            SetThemeAppProperties(STAP_ALLOW_NONCLIENT | STAP_ALLOW_CONTROLS | STAP_ALLOW_WEBCONTENT);
        }

        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint="GetSystemDirectoryW")]
        public static extern  uint GetSystemDirectory([Out, MarshalAs(UnmanagedType.LPWStr)] 
            StringBuilder lpBuffer, uint uSize) ;


        public static  uint EnableVisualStyles()
        {
	        string dir = System.Reflection.Assembly.GetExecutingAssembly().Location;;
            
            ACTCTX actCtx = new ACTCTX()
	        {
				cbSize = Marshal.SizeOf(typeof(ACTCTX)), 
				dwFlags = ACTCX_FALGS.ACTCTX_FLAG_RESOURCE_NAME_VALID , 
				lpSource=  dir, 
				wLangId = 0,
				lpResourceName =new IntPtr(101)

	        };

            IntPtr hActCtx = CreateActCtx(ref actCtx);
            bool contextCreationSucceeded = (hActCtx != new IntPtr(-1));

            if (!contextCreationSucceeded)
            {
                actCtx.lpResourceName =(IntPtr) ACTCX_FALGS.ISOLATIONAWARE_NOSTATICIMPORT_MANIFEST_RESOURCE_ID;
                hActCtx = CreateActCtx(ref actCtx);
                contextCreationSucceeded = (hActCtx != new IntPtr(-1));
            }

            if (!contextCreationSucceeded)
            {
                actCtx.lpResourceName = (IntPtr) ACTCX_FALGS.CREATEPROCESS_MANIFEST_RESOURCE_ID;
                hActCtx = CreateActCtx(ref actCtx);
                contextCreationSucceeded = (hActCtx != new IntPtr(-1));
            }

            ActivateActCtx(hActCtx,out var ulpActivationCookie);
	        return ulpActivationCookie;
        }


        /// Return Type: BOOL->int
        ///hActCtx: HANDLE->void*
        ///lpCookie: ULONG_PTR*
        [DllImport("kernel32.dll", EntryPoint="ActivateActCtx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool ActivateActCtx(IntPtr hActCtx, [Out] out uint lpCookie) ;

        /// Return Type: HANDLE->void*
        ///pActCtx: PCACTCTXW->ACTCTXW*
        [DllImport("kernel32.dll", EntryPoint="CreateActCtxW")]
        public static extern  IntPtr CreateActCtx([In] ref ACTCTX pActCtx) ;


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint="OpenProcess")]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwProcessId);

        /// Return Type: BOOL->int
        ///hObject: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint="CloseHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool CloseHandle([In] IntPtr hObject) ;

        public static IntPtr GetProcessHandleFromId(uint dwProcessId)
        {
            return OpenProcess((uint) ProcessAccessTypes.SYNCHRONIZE, true, dwProcessId);
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
        [DllImport("user32.dll", EntryPoint="SetWinEventHook")]
        public static extern  IntPtr SetWinEventHook(uint eventMin, uint eventMax, [In] IntPtr hmodWinEventProc, WinEventProc pfnWinEventProc, uint idProcess, uint idThread, uint dwFlags) ;

        public static IntPtr HookWindowEvent( WinEventProc pfnWinEventProc, uint processId, uint threadId)
        {
            return SetWinEventHook(EVENT_MIN, EVENT_MAX, IntPtr.Zero, pfnWinEventProc, processId, threadId,
                WINEVENT_OUTOFCONTEXT | WINEVENT_SKIPOWNPROCESS);
        }

        /// Return Type: BOOL->int
        ///hWinEventHook: HWINEVENTHOOK->HWINEVENTHOOK__*
        [DllImport("user32.dll", EntryPoint="UnhookWinEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool UnhookWinEvent([In] IntPtr hWinEventHook) ;


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

        public static bool GetClassInfoEx(IntPtr instanceHandle, string className, out Wndclassex wndclassex)
        {
            Wndclassex wnd = Wndclassex.Build();

            bool val = GetClassInfoExW(instanceHandle, className, ref wnd);
            wndclassex = new Wndclassex();
            if (val)
            {
                wndclassex.cbClsExtra = wnd.cbClsExtra;
                wndclassex.cbSize = (int)wnd.cbSize;
                wndclassex.cbWndExtra = wnd.cbWndExtra;
                wndclassex.hbrBackground = wnd.hbrBackground;
                wndclassex.hCursor = wnd.hCursor;
                wndclassex.hIcon = wnd.hIcon;
                wndclassex.hIconSm = wnd.hIconSm;
                wndclassex.hInstance = wnd.hInstance;
                wndclassex.lpfnWndProc = Marshal.GetFunctionPointerForDelegate( wnd.lpfnWndProc);
                wndclassex.lpszClassName = wnd.lpszClassName;
                wndclassex.lpszMenuName = wnd.lpszMenuName;
                wndclassex.style = wnd.style;

            }
            

            return val;
        }
    }

    internal class ACTCX_FALGS {
    
        public const uint ACTCTX_FLAG_PROCESSOR_ARCHITECTURE_VALID = 0x001;
        public const uint ACTCTX_FLAG_LANGID_VALID = 0x002;
        public const uint ACTCTX_FLAG_ASSEMBLY_DIRECTORY_VALID = 0x004;
        public const uint ACTCTX_FLAG_RESOURCE_NAME_VALID = 0x008;
        public const uint ACTCTX_FLAG_SET_PROCESS_DEFAULT = 0x010;
        public const uint ACTCTX_FLAG_APPLICATION_NAME_VALID = 0x020;
        public const uint ACTCTX_FLAG_HMODULE_VALID = 0x080;
        public const uint RT_MANIFEST = 24;
        public const uint CREATEPROCESS_MANIFEST_RESOURCE_ID = 1;
        public const uint ISOLATIONAWARE_MANIFEST_RESOURCE_ID = 2;
        public const uint ISOLATIONAWARE_NOSTATICIMPORT_MANIFEST_RESOURCE_ID = 3;
    }


    [StructLayout(LayoutKind.Sequential)]
    internal struct ACTCTX {
    
	
        public int cbSize;
        public uint dwFlags;
        public string lpSource;
        public ushort wProcessorArchitecture;
        public ushort wLangId;
        public string lpAssemblyDirectory;
        public IntPtr lpResourceName;
        public string lpApplicationName;

    }
}


