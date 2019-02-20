using System;
using CoreWindowsWrapper.Win32ApiForm;

namespace CoreWindowsWrapper
{
    public class NativeNoCreateControlBase:NativeControlBase
    {
        protected override void Initialize()
        {
            this.Control = new Win32NoCreateControl();
        }

        public override bool Create(IntPtr parentHandle)
        {
            this.ParentHandle = parentHandle;
            return true;
        }
    }
}