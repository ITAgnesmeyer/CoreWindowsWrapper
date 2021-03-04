using Diga.Core.Api.Win32;
using System;
using Diga.Core.Api.Win32.GDI;

// ReSharper disable CheckNamespace

namespace CoreWindowsWrapper.Tools
{
    public static class FontTool
    {
        internal static int FontSizeToHeight(int size, IntPtr hDc)
        {
            int devCap = Gdi32.GetDeviceCaps(hDc, LogPixels.LOGPIXELSY);
            return -Win32Api.MulDiv(size, devCap, 72);
        }

        internal static int FontHeightToSize(int height, IntPtr hDc)
        {
            int devCap = Gdi32.GetDeviceCaps(hDc, LogPixels.LOGPIXELSY);
            return -Win32Api.MulDivReverse(height, devCap, 72);
        }

        internal static LogFont GetDefaultLogFont()
        {
            User32.GetDefaultLogFont(out var lf);
            return lf;
        }
    }
}
