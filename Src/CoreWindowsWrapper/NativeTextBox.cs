using System;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeTextBox : NativeControlBase
    {
        public event EventHandler Change;
        protected override void Initialize()
        {
            base.Initialize();
            this.TypeIdentifier = "edit";
            
        }

        public override  string Text
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
            bool handled = false;
            switch (command)
            {
                case EditBoxMessaes.EN_CHANGE:
                    OnChange();
                    handled = true;
                    break;
               

            }

            return handled;

        }

        protected virtual void OnChange()
        {
            Change?.Invoke(this, EventArgs.Empty);
        }
    }
}