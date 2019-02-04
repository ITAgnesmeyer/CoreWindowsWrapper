using System;

namespace CoreWindowsWrapper
{
    public interface  IWindow 
    {
        IntPtr Handle { get; }
    }
}