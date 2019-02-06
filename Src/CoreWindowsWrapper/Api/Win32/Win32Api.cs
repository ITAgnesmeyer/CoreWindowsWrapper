﻿using System;
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
        public static extern UIntPtr SetTimer([In()] IntPtr hWnd, UIntPtr nIDEvent, uint uElapse, TIMERPROC lpTimerFunc);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///uIDEvent: UINT_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "KillTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool KillTimer([In()] IntPtr hWnd, UIntPtr uIDEvent);




        [DllImport("user32.dll")]
        public static extern bool UpdateWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool DestroyWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool AppendMenu(IntPtr hMenu, MenuFlags uFlags, uint uIDNewItem, string lpNewItem);

        [DllImport("user32.dll", SetLastError = true, EntryPoint = "CreateWindowEx")]
        public static extern IntPtr CreateWindowEx(
            int dwExStyle,
            //UInt16 regResult,
            [MarshalAs(UnmanagedType.LPStr)]
            string lpClassName,
            [MarshalAs(UnmanagedType.LPStr)]
            string lpWindowName,
            UInt32 dwStyle,
            int x,
            int y,
            int nWidth,
            int nHeight,
            IntPtr hWndParent,
            IntPtr hMenu,
            IntPtr hInstance,
            IntPtr lpParam);

        [DllImport("user32.dll", SetLastError = true, EntryPoint = "RegisterClassEx")]
        public static extern UInt16 RegisterClassEx([In] ref Wndclassex lpWndClass);

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
        public static extern IntPtr LoadImage([In()] IntPtr hInst, [In()] [MarshalAs(UnmanagedType.LPWStr)] string name, uint type, int cx, int cy, uint fuLoad);



        [DllImport("user32.dll")]
        public static extern bool TranslateMessage([In] ref MSG lpMsg);

        [DllImport("user32.dll")]
        public static extern IntPtr DispatchMessage([In] ref MSG lpmsg);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool SetWindowText(IntPtr hwnd, String lpString);

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


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///index: int
        [DllImport("gdi32.dll", EntryPoint = "GetDeviceCaps")]
        public static extern int GetDeviceCaps([In()] IntPtr hdc, int index);

        /// Return Type: HFONT->HFONT__*
        ///lplf: LOGFONTW*
        [DllImport("gdi32.dll", EntryPoint = "CreateFontIndirectW")]
        public static extern IntPtr CreateFontIndirect([In()] ref LOGFONTW lplf);


        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetObject(IntPtr hObject, int nSize, [In(), Out()] LOGFONTW lf);

            /// Return Type: int
    ///h: HANDLE->void*
    ///c: int
    ///pv: LPVOID->void*
    [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll", EntryPoint="GetObjectW")]
public static extern  int GetObjectW([In()] IntPtr h, int c, IntPtr pv) ;


        public static int GetObject(IntPtr hObject, LOGFONTW lp)
        {
            return GetObject(hObject, Marshal.SizeOf(typeof(LOGFONTW)), lp);
        }


        /// Return Type: BOOL->int
        ///uiAction: UINT->unsigned int
        ///uiParam: UINT->unsigned int
        ///pvParam: PVOID->void*
        ///fWinIni: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfoW(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);

        [DllImport("user32.dll", EntryPoint = "SystemParametersInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfo(uint uiAction, int uiParam, ref LOGFONTW logFont, int fWinIni);



        public static bool GetDefaultLogFont(out LOGFONTW logFont)
        {
            LOGFONTW lFont = new LOGFONTW();
            
            int size = Marshal.SizeOf(typeof(LOGFONTW));
            bool retVal = SystemParametersInfo(SpiConst.SPI_GETICONTITLELOGFONT,size,ref lFont,0 );
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
            SendMessage(hWnd, (int)WindowsMessages.WM_SETTEXT, (int)IntPtr.Zero, txt);
            Marshal.FreeCoTaskMem(txt);

        }

        public static string GetWindowTextRaw(IntPtr hwnd)
        {
            // Allocate correct string length first
            int length = (int)SendMessage(hwnd, (int)WindowsMessages.WM_GETTEXTLENGTH, (int)IntPtr.Zero, IntPtr.Zero);
            StringBuilder sb = new StringBuilder(length + 1);
            SendMessage(hwnd, (int)WindowsMessages.WM_GETTEXT, (IntPtr)sb.Capacity, sb);
            return sb.ToString();
        }

        //[DllImport(dllName:"user32.dll", EntryPoint = "MessageBoxW", SetLastError=true, CharSet = CharSet.Unicode)]
        //public static extern int MessageBox(IntPtr hWnd, [MarshalAs(UnmanagedType.LPTStr)] string text, [MarshalAs(UnmanagedType.LPTStr)] string caption, uint options);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetActiveWindow();

        [DllImport("kernel32.dll")]
        public static extern ushort GetSystemDefaultLangID();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetWindowRect(IntPtr hwnd, out Rect lpRect);

        [DllImport("gdi32.dll")]
        public static extern IntPtr GetStockObject(StockObjects fnObject);

        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("User32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        [DllImport("User32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, SetWindowPosFlags uFlags);


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
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, ref IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, uint wParam = 0, uint lParam = 0);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, out HighLow lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, HighLow lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, int lParam);



        ///pvReserved: LPVOID->void*
        [DllImport("ole32.dll", EntryPoint = "OleInitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleInitialize(IntPtr pvReserved);

        /// Return Type: void
        [DllImport("ole32.dll", EntryPoint = "OleUninitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern void OleUninitialize();



        [DllImport("comctl32.dll", EntryPoint = "InitCommonControlsEx", CallingConvention = CallingConvention.StdCall)]
        public static extern bool InitCommonControlsEx(ref INITCOMMONCONTROLSEX iccex);



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
            return (IntPtr)((hiWord << 16) | (loWord & 0xffff));
        }

        public static int MulDiv(int number, int numerator, int denominator)
        {
            return (int)((long)number * numerator / denominator);
        }

        public static int MulDivReverse(int number, int numerator, int dimension)
        {
            return (int)((long)number * dimension / numerator);
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
    }
}