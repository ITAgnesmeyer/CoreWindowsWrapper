using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper.Tools
{
    internal class ImageTool
    {

        [DllImport("user32.dll", EntryPoint="LoadIcon" , CharSet = CharSet.Auto)]
        public static extern IntPtr LoadIcon([In] IntPtr hInstance, [In] IntPtr id) ;


        public static IntPtr SafeLoadIconFromFile(string filePath)
        {
            IntPtr hIcon = User32.LoadImage(IntPtr.Zero, filePath, ImageTypeConst.IMAGE_ICON, 0, 0,
                LoadResourceConst.LR_LOADFROMFILE | LoadResourceConst.LR_DEFAULTSIZE | LoadResourceConst.LR_SHARED);

            return hIcon;
        }


        public static IntPtr SafeLoadBitmapFromFile(string filePath)
        {
            IntPtr hBmp = User32.LoadImage(IntPtr.Zero, filePath, ImageTypeConst.IMAGE_BITMAP, 0, 0,
                LoadResourceConst.LR_LOADFROMFILE | LoadResourceConst.LR_DEFAULTSIZE | LoadResourceConst.LR_SHARED);
            
            return hBmp;
        }

        public static IntPtr LoadAppIcon()
        {
            //return ResourceLoader.Loader.LoadIcon(32512);
            IntPtr hIcon = LoadIcon(IntPtr.Zero, Win32Api.MakeInterSource((int)StdIcons.IDI_APPLICATION));
            return hIcon;
        }

      

        public static IntPtr LoadHandIcon()
        {
            return LoadIcon(IntPtr.Zero, Win32Api.MakeInterSource((int)StdIcons.IDI_HAND));
        }

        public static IntPtr LoadQuestionIcon()
        {
            return LoadIcon(IntPtr.Zero, Win32Api.MakeInterSource((int)StdIcons.IDI_QUESTION));
        }

        public static IntPtr LoadExclamationIcon()
        {
            return LoadIcon(IntPtr.Zero, Win32Api.MakeInterSource((int)StdIcons.IDI_EXCLAMATION));
        }
        public static IntPtr LoadAsteriskIcon()
        {
            return LoadIcon(IntPtr.Zero, Win32Api.MakeInterSource((int)StdIcons.IDI_ASTERISK));
        }

        public static IntPtr LoadWinLogoIcon()
        {
            return LoadIcon(IntPtr.Zero, Win32Api.MakeInterSource((int)StdIcons.IDI_WINLOGO));
        }

        public static IntPtr LoadShieldIcon()
        {
            IntPtr hIcon = LoadIcon(IntPtr.Zero, Win32Api.MakeInterSource((int)StdIcons.IDI_SHIELD));
            return hIcon;
        }
        public static IntPtr LoadWarningIcon()
        {
            return LoadIcon(IntPtr.Zero, Win32Api.MakeInterSource((int)StdIcons.IDI_WARNING));
        }

        public static IntPtr LoadErrorIcon()
        {
            return LoadIcon(IntPtr.Zero, Win32Api.MakeInterSource((int)StdIcons.IDI_ERROR));
        }
        public static IntPtr LoadInformationIcon()
        {
            return LoadIcon(IntPtr.Zero, Win32Api.MakeInterSource((int)StdIcons.IDI_INFORMATION));
        }
        public static IntPtr SafeLoadIconFromResource(int resId)
        {
            return SafeLoadIconFromResource(Kernel32.GetModuleHandle(null), resId);
        }
        public static IntPtr SafeLoadIconFromResource(IntPtr instance,int resId)
        {
            IntPtr hIcon = User32.LoadImage(instance, Win32Api.MakeInterSource(resId), ImageTypeConst.IMAGE_ICON,
                User32.GetSystemMetrics(SystemMetric.SM_CXSMICON),
                User32.GetSystemMetrics(SystemMetric.SM_CYSMICON), 0);
            
            if (hIcon == IntPtr.Zero)
            {
                Win32Exception ex = new Win32Exception(Marshal.GetLastWin32Error());
                Debug.Print(ex.Message);
            }

            return hIcon;
        }

        public static IntPtr SafeLoadBitmapFromResource(int resId)
        {
            return SafeLoadBitmapFromResource(Kernel32.GetModuleHandle(null), resId);
        }
        public static IntPtr SafeLoadBitmapFromResource(IntPtr instance, int resId)
        {
            IntPtr hBmp = User32.LoadImage(instance, Win32Api.MakeInterSource(resId), ImageTypeConst.IMAGE_BITMAP, 0, 0,
                LoadResourceConst.LR_DEFAULTSIZE | LoadResourceConst.LR_SHARED);
            return hBmp;
        }

    }
}
