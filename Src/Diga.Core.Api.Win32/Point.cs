using System.Runtime.InteropServices;

namespace Diga.Core.Api.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static implicit operator HighLow(Point input)
        {
            return new HighLow() { iLow = input.X, iHigh = input.Y };
        }

        public static implicit operator Point(HighLow input)
        {
            return new Point(input.iLow, input.iHigh);
        }
        public static implicit operator System.Drawing.Point(Point input)
        {
            return new System.Drawing.Point(input.X, input.Y);
        }

        public static implicit operator Point(System.Drawing.Point input)
        {
            return new Point(input.X, input.Y);
        }
    }
}