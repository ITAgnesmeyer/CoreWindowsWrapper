using System;

namespace CoreWindowsWrapper
{
    [Serializable]
    public class SizeEventArgs : EventArgs
    {
        public int X{get;set;}
        public int Y { get;set; }
        public int Width{get;set;}
        public int Height{get;set;}

        public SizeEventArgs(int x , int y , int width, int height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }
    }
}