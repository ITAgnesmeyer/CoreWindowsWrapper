using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.Core.Api.Win32;
using Diga.Core.Api.Win32.Com;
using Diga.Core.Api.Win32.Dwm;
namespace CoreWindowsWrapper
{
    public enum TheamingBackDropType:int
    {
        Auto,
        None,
        MainWindow,
        TransientWindow,
        TabbedWindow


    }
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
                    del(1);
            }
            Kernel32.FreeLibrary(hUxTheme);
        }
        
        public static void SetWindowBackDrop(IntPtr hWnd, TheamingBackDropType backDropType)
        {
            using (var p = new ApiStructHandleRef<int>((int)backDropType))
            {

                int r = DwmApi.DwmSetWindowAttribute(hWnd, (uint)38, p, (uint)Marshal.SizeOf<int>());
                if (r != 0)
                {
                    var ex = Marshal.GetExceptionForHR(r);
                    if (ex != null)
                    {
                        Debug.Print(ex.Message);
                    }
                }
                //int v = p.GetStruct();

            }

        }
        public static bool SetTheme(IntPtr hWnd, string themeName, string subThemeName = null)
        {
            HRESULT hr = UxTheme.SetWindowTheme(hWnd, themeName, subThemeName);
            if(hr != 0)
            {
                var ex = Marshal.GetExceptionForHR(hr);
                if (ex != null)
                {
                    Debug.Print(ex.Message);
                }
                return false;
            }
            return true;
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