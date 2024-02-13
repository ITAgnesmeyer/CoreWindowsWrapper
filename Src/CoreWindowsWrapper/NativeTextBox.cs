using System;
using System.Diagnostics;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeTextBox : NativeControlBase
    {
        public event EventHandler<EventArgs> Change;
        public event EventHandler<EventArgs> SetFocus;
        public event EventHandler<EventArgs> KillFocus;
        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.Edit;
            this.TypeIdentifier = "edit";
            this.Style |= EditBoxStyles.ES_AUTOHSCROLL;

            this.BackColor = Tools.ColorTool.White;
            this.ForeColor = Tools.ColorTool.Black;

        }

        public override string Text
        {
            get => User32.GetWindowTextRaw(this.Handle);
            set
            {
                base.Text = value;
                User32.SetWindowTextsRaw(this.Handle, value);

            }
        }


        protected override bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
            bool handled = false;
            Debug.Print($"NativeTextBox:0x{command.ToString("x4")}");
            switch (command)
            {
                case EditBoxMessages.EN_SETFOCUS:
                    OnSetFocus();
                    handled = true;
                    break;
                case EditBoxMessages.EN_KILLFOCUS:
                    OnKillFocus();
                    handled = true;
                    break;
                
                case EditBoxMessages.EN_CHANGE:
                    OnChange();
                    handled = true;
                    break;
              

            }

            return handled;

        }
        protected virtual void OnKillFocus()
        {
            SafeInvoke(this.KillFocus , EventArgs.Empty);
        }
        protected virtual void OnSetFocus()
        {
            SafeInvoke(this.SetFocus , EventArgs.Empty);
        }
        protected virtual void OnChange()
        {
            //Change?.Invoke(this, EventArgs.Empty);
            SafeInvoke(this.Change, EventArgs.Empty);
        }
    }
}