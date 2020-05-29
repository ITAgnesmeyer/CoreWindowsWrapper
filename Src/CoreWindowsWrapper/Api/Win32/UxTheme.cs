using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    internal static class UxTheme
    {
        /// Return Type: void
        ///dwFlags: DWORD->unsigned int
        [DllImport("UxTheme.dll", EntryPoint = "SetThemeAppProperties")]
        public static extern void SetThemeAppProperties(uint dwFlags);

        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hWnd, String pszSubAppName, String pszSubIdList);

        public const int STAP_ALLOW_NONCLIENT = (1 << 0);
        public const int STAP_ALLOW_CONTROLS = (1 << 1);
        public const int STAP_ALLOW_WEBCONTENT = (1 << 2);

        public static void EnableTheme()
        {
            UxTheme.SetThemeAppProperties(STAP_ALLOW_NONCLIENT | STAP_ALLOW_CONTROLS | STAP_ALLOW_WEBCONTENT);
        }
    }
}