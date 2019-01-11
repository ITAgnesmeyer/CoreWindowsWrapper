using System;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    public interface  IWindow 
    {
        IntPtr Handle { get; }
    }

    internal interface IWindowClass
    {
        Wndclassex WindowClass { get; set; }
    }
}