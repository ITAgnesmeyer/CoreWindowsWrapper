using System;
using Diga.Core.Api.Win32;
using Diga.Core.Api.Win32.GDI;

// ReSharper disable CheckNamespace

namespace CoreWindowsWrapper.Tools
{
    public static class ColorTool
    {
        public static int White => Rgb(255, 255, 255);
        public static int Black => Rgb(0, 0, 0);
        public static int Read => Rgb(255, 0, 0);
        public static int Green => Rgb(0, 255, 0);
        public static int Blue => Rgb(0, 0, 255);
        public static int Yellow => Rgb(255, 255, 0);
        public static int LightGray => Rgb(224, 224, 224);
        public static int Gray => Rgb(128, 128, 128);
        public static int ControlBackground => 0xF0F0F0;

        public static int Rgb(int red, int green, int blue)
        {
            if ((red & -2147483648) != 0)
            {
                throw new ArgumentException("invalid Read Value");
            }

            if ((green & -2147483648) != 0)
            {
                throw new ArgumentException("Invalid Green Value");
            }

            if ((blue & -2147483648) != 0)
            {
                throw new ArgumentException("Invalid Blue Value");
            }

            if (red > 255)
            {
                red = 255;
            }

            if (green > 255)
            {
                green = 255;
            }

            if (blue > 255)
            {
                blue = 255;
            }

            return Gdi32.RGB(red, green, blue);
        }
    }
}
