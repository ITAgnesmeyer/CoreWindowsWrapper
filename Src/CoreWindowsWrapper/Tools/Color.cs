using System;

namespace CoreWindowsWrapper.Tools
{
    public static class ColorTool
    {
        public static  int White => RGB(255, 255, 255);
        public static int Black=>RGB(0,0,0);
        public static int Read=>RGB(255,0,0);
        public static int Green=>RGB(0,255,0);
        public static int Blue=>RGB(0,0,255);
        public static int Yellow=>RGB(255,255,0);
        public static int LightGray=>RGB(224,224,224);
        public static int Gray=>RGB(128,128,128);


         public static int RGB(int Red, int Green, int Blue)
        {
            if ((Red & -2147483648) != 0)
            {
                throw new ArgumentException("invalid Read Value");
            }
            if ((Green & -2147483648) != 0)
            {
                throw new ArgumentException("Invalid Green Value" );
            }
            if ((Blue & -2147483648) != 0)
            {
                throw new ArgumentException("Invalid Blue Value" );
            }
            if (Red > 255)
            {
                Red = 255;
            }
            if (Green > 255)
            {
                Green = 255;
            }
            if (Blue > 255)
            {
                Blue = 255;
            }
            return Api.Win32.Win32Api.RGB(Red,Green,Blue);
        }

    }
}
