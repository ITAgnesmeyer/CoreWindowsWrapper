using System;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeLabel : NativeControlBase
    {
        

        protected override void Initialize()
        {
            base.Initialize();
            this.TypeIdentifier = "static";
            this.BackColor = Tools.ColorTool.White;
        }

        public override string Text
        {
            get => Win32Api.GetWindowTextRaw(this.Handle);
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