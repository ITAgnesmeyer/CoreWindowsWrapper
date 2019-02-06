﻿using System;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    internal interface  IControl:IWindow
    {
        IntPtr ParentHandle { get; set; }
        string Name { get; set; }
        string Text { get; set; }
        int BackColor { get; set; }
        int ForeColor{get;set;}
        int Left { get; set; }
        int Top { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        Point Location { get; set; }
        int ControlId { get; set; }
        bool Create(IntPtr parentId);
        void Destroy();
        bool HandleEvents(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam,
            IntPtr lParam);


    }
}