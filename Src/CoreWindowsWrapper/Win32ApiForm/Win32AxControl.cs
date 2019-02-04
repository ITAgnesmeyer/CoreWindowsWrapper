using System;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper.Win32ApiForm
{

    internal class Win32AxControl:Win32Control
    {
        internal override bool Create(IntPtr parentHandle)
        {
            if (this.CommonControType != CommonControls.ICC_UNDEFINED)
            {
                INITCOMMONCONTROLSEX ccInit = new INITCOMMONCONTROLSEX(this.CommonControType);
                Win32Api.InitCommonControlsEx(ref ccInit);
            }
            this.ParentHandle = parentHandle;
            this.Handle  = Win32Api.CreateWindowEx(0,
                this.TypeIdentifyer , this.Text,
                this.Style, this.Left ,
                this.Top,
                this.Width, this.Height, this.ParentHandle,
                (IntPtr) this.ControlId, IntPtr.Zero, IntPtr.Zero);

     
            return true;

        }
    }
}