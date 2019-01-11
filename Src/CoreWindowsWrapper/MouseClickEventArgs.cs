using System;
using CoreWindowsWrapper.Api.Win32;

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
}