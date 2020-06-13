using System;

using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    [Serializable]
    public class MouseClickEventArgs : EventArgs
    {
        public MouseButton Button { get; }
        public IntPtr Handel { get; }



        public MouseClickEventArgs(MouseButton button, IntPtr handel)
        {
            this.Button = button;
            this.Handel = handel;
        }
    }

    [Serializable]
    public class MouseClickPositionEventArgs : MouseClickEventArgs
    {
        public Point Point{get;}
        public MouseKey MouseButton{get;}
        public MouseClickPositionEventArgs(MouseButton button, IntPtr handel, Point point, MouseKey mouseButton) : base(button, handel)
        {
            this.Point = point;
            this.MouseButton = mouseButton;
        }
    }
    
}