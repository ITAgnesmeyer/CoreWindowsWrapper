using System;
using System.Runtime.InteropServices;
using Diga.Core.Api.Win32;
namespace CoreWindowsWrapper
{
    public static class NativeTheaming
    {
        /// Return Type: boolean
        ///hWnd: HWND->HWND__*
        ///allow: boolean
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public delegate bool fnAllowDarkModeForWindow(IntPtr hWnd, [MarshalAs(UnmanagedType.I1)] bool allow);

        /// Return Type: PreferredAppMode
        ///appMode: PreferredAppMode
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int fnSetPreferredAppMode(int appMode);

        /// Return Type: boolean
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate bool fnShouldAppsUseDarkMode();
        public static void InitTheaming()
        {
            IntPtr hUxTheme = Kernel32.LoadLibraryEx("uxtheme.dll", IntPtr.Zero, LoadLibraryExFlags.LOAD_LIBRARY_SEARCH_SYSTEM32);
            if (hUxTheme == IntPtr.Zero)
                return;

            IntPtr hProcAddr = Kernel32.GetProcAddress(hUxTheme, Win32Api.MakeInterSource(135));
            if (hProcAddr != IntPtr.Zero)
            {


                fnSetPreferredAppMode del = Marshal.GetDelegateForFunctionPointer<fnSetPreferredAppMode>(hProcAddr);
                if (del != null)
                    del(0);
            }
            Kernel32.FreeLibrary(hUxTheme);
        }

        public static void SetThemaing(IntPtr hWnd)
        {
            IntPtr hUxTheme = Kernel32.LoadLibraryEx("uxtheme.dll", IntPtr.Zero, LoadLibraryExFlags.LOAD_LIBRARY_SEARCH_SYSTEM32);
            if (hUxTheme == IntPtr.Zero)
                return;

            IntPtr hProcAddr = Kernel32.GetProcAddress(hUxTheme, Win32Api.MakeInterSource(133));
            if (hProcAddr != IntPtr.Zero)
            {
                fnAllowDarkModeForWindow del = Marshal.GetDelegateForFunctionPointer<fnAllowDarkModeForWindow>(hProcAddr);
                if (del != null)
                {
                    UxTheme.SetWindowTheme(hWnd, "Explorer", null);
                    del(hWnd, true);
                    User32.SendMessage(hWnd, WindowsMessages.WM_THEMECHANGED, 0, 0);
                }
            }
            Kernel32.FreeLibrary(hUxTheme);
        }
    }
}