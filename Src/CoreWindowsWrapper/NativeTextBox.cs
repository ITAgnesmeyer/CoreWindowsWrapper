using System;
using System.Net.Mime;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeTextBox : NativeControlBase
    {
        public event EventHandler Change;
        protected override void Initialize()
        {
            base.Initialize();
            this.TypeBezeichner = "edit";
            
        }

        public override  string Text
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
            bool handeld = false;
            switch (command)
            {
                case EditBoxMessaes.EN_CHANGE:
                    OnChange();
                    handeld = true;
                    break;
               

            }

            return handeld;

        }

        protected virtual void OnChange()
        {
            Change?.Invoke(this, EventArgs.Empty);
        }
    }
}