using System;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeLabel : NativeControlBase
    {
        

        protected override void Initialize()
        {
            base.Initialize();
            this.TypeBezeichner = "static";
        }

        public override string Text
        {
            get { return Win32Api.GetWindowTextRaw(this.Handle); }
            set
            {
                base.Text = value;
                Win32Api.SetWindowTextsRaw(this.Handle,value);

            }
        }

        protected override bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
           
           

            return false;
        }

       
    }
}