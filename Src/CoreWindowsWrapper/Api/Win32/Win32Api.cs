using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CoreWindowsWrapper.Api.Win32
{
    internal static class Win32Api
    {
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
        public static extern System.UInt16 RegisterClassEx([In] ref Wndclassex lpWndClass);

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


        [DllImport("gdi32.dll", EntryPoint="CreateSolidBrush", SetLastError=true)]
        public static extern IntPtr CreateSolidBrush( int crColor );


        [DllImport ("coredll.dll", EntryPoint="SetBkColor", SetLastError=true)]
        public static extern uint SetBkColor(IntPtr hdc, int crColor);

        [DllImport("coredll", EntryPoint="GetDC", SetLastError=true)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("coredll.dll", EntryPoint="ReleaseDC", SetLastError=true)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);


        // ReSharper disable once InconsistentNaming

        public static int RGB(int r, int g, int b) => checked(checked(checked(b * 65536) + checked(g * 256)) + r);


        public static void SetWindowTextsRaw(IntPtr hWnd, string text)
        {
            IntPtr txt = Marshal.StringToCoTaskMemUni(text);
            SendMessage(hWnd, (int)WindowsMessages.WM_SETTEXT, (int) IntPtr.Zero, txt);
            Marshal.FreeCoTaskMem(txt);

        }

        public static string GetWindowTextRaw(IntPtr hwnd)
        {
            // Allocate correct string length first
            int length = (int)SendMessage(hwnd,(int) WindowsMessages.WM_GETTEXTLENGTH, (int) IntPtr.Zero, IntPtr.Zero);
            StringBuilder sb = new StringBuilder(length + 1);
            SendMessage(hwnd, (int) WindowsMessages.WM_GETTEXT, (IntPtr)sb.Capacity, sb);
            return sb.ToString();
        }

        //[DllImport(dllName:"user32.dll", EntryPoint = "MessageBoxW", SetLastError=true, CharSet = CharSet.Unicode)]
        //public static extern int MessageBox(IntPtr hWnd, [MarshalAs(UnmanagedType.LPTStr)] string text, [MarshalAs(UnmanagedType.LPTStr)] string caption, uint options);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetActiveWindow();

        [DllImport("kernel32.dll")]
        public static extern ushort GetSystemDefaultLangID();

        [DllImport("gdi32.dll")]
        public static extern IntPtr GetStockObject(StockObjects fnObject);

        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);


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
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam,out HighLow lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, HighLow lParam);

      


        [DllImport( "comctl32.dll", EntryPoint = "InitCommonControlsEx", CallingConvention = CallingConvention.StdCall)] 
        public static extern bool InitCommonControlsEx (ref INITCOMMONCONTROLSEX iccex); 

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
    }
}