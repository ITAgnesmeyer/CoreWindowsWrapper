using System;

namespace CoreWindowsWrapper.Win32ApiForm
{
    internal class Win32NoCreateControl : Win32Control
    {
        internal override bool Create(IntPtr parentHandle)
        {
            //if(this.ControlId == 0)
            //{
            //    LastControlId += 1;
            //    this.ControlId = LastControlId;
            //}
            return true;
        }
    }
}