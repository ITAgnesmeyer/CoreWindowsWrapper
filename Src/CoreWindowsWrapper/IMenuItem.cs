using System;

namespace CoreWindowsWrapper
{
    public interface IMenuItem
    {
        int Id{get;set;}
        IntPtr Handle{get;set;}
        string Name{get;set;}
        string Text{get;set;}
        IntPtr ParentMenuHandle{get;set;}
        void Create(IntPtr parentMenuHandle);
        bool HandleEvents(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam,
            IntPtr lParam);
        void Destroy();

    }
}