using System;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper.Win32ApiForm
{
    internal class Win32AxControl : Win32Control
    {
        internal override bool Create(IntPtr parentHandle)
        {
            //if(this.ControlId == 0)
            //{
            //    LastControlId +=1;
            //    this.ControlId = LastControlId;
            //}
            if (this.CommonControlType != CommonControls.ICC_UNDEFINED)
            {
                InitCommonControlsEx ccInit = new InitCommonControlsEx(this.CommonControlType);
                ComCtl32.InitCommonControlsEx(ref ccInit);
            }

            this.ParentHandle = parentHandle;
            this.Handle = User32.CreateWindowEx(0,
                "static", this.Text,
                this.Style, this.Left,
                this.Top,
                this.Width, this.Height, this.ParentHandle,
                (IntPtr) this.ControlId, IntPtr.Zero, IntPtr.Zero);


            return true;
        }
    }
}