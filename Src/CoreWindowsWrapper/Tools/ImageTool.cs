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
            return LoadIcon(IntPtr.Zero, Win32Api.MakeInterSource(32512));
        }

        public static IntPtr SafeLoadIconFromResource(int resId)
        {
            return SafeLoadIconFromResource(IntPtr.Zero, resId);
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
            return SafeLoadBitmapFromResource(IntPtr.Zero, resId);
        }
        public static IntPtr SafeLoadBitmapFromResource(IntPtr instance, int resId)
        {
            IntPtr hBmp = User32.LoadImage(instance, Win32Api.MakeInterSource(resId), ImageTypeConst.IMAGE_BITMAP, 0, 0,
                LoadResourceConst.LR_DEFAULTSIZE | LoadResourceConst.LR_SHARED);
            return hBmp;
        }

    }
}
