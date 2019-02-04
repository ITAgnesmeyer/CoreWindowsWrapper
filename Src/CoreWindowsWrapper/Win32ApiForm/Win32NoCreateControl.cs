using System;

namespace CoreWindowsWrapper.Win32ApiForm
{
    internal class Win32NoCreateControl:Win32Control
    {
        internal override bool Create(IntPtr parentHandle)
        {
            return true;
        }
    }
}