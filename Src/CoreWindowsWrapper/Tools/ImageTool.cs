using System;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper.Tools
{
    internal class ImageTool
    {
        public static IntPtr SaveLoadIconFromFile(string filePath)
        {
            IntPtr hIcon = Win32Api.LoadImage(IntPtr.Zero, filePath, ImageTypeConst.IMAGE_ICON, 0, 0,
                LoadResourceConst.LR_LOADFROMFILE | LoadResourceConst.LR_DEFAULTSIZE | LoadResourceConst.LR_SHARED);

            return hIcon;
        }

        public static IntPtr SaveLoadBitmapFromFile(string filePath)
        {
            IntPtr hBmp = Win32Api.LoadImage(IntPtr.Zero, filePath, ImageTypeConst.IMAGE_BITMAP, 0, 0,
                LoadResourceConst.LR_LOADFROMFILE | LoadResourceConst.LR_DEFAULTSIZE | LoadResourceConst.LR_SHARED);
            return hBmp;
        }
    }
}
