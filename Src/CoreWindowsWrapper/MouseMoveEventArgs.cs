using System;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper.Win32ApiForm
{
    public class MouseMoveEventArgs : EventArgs
    {
        public MouseMoveEventArgs(Point point, MouseKey mouseButton)
        {
            this.Point = point;
            this.MouseButton = mouseButton;
        }

        public Point Point{get;}
        public MouseKey MouseButton{get;}

    }
}