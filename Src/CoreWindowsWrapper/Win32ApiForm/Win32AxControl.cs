using System;
using CoreWindowsWrapper.Api.Win32;

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
            if (this.CommonControType != CommonControls.ICC_UNDEFINED)
            {
                INITCOMMONCONTROLSEX ccInit = new INITCOMMONCONTROLSEX(this.CommonControType);
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