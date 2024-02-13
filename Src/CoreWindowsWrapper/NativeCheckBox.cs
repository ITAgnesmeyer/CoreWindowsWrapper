using System;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeCheckBox:NativeButton
    {
        private bool _Checked;
        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.CheckBox;
            this.Style = this.Style |ButtonStyles.BS_CHECKBOX | ButtonStyles.BS_NOTIFY;
            
        }

        protected override void AfterCreate()
        {
            base.AfterCreate();
            this.Checked = this._Checked;
        }

        protected override bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
            bool handled = false;
            switch (command)
            {
                case 0:
                    uint check = User32.IsDlgButtonChecked(hWndParent, controlId);
                    if(check == 1)
                        User32.CheckDlgButton(hWndParent, controlId,0);
                    else
                        User32.CheckDlgButton(hWndParent,controlId,1);
                    handled = true;
                    break;
                default:
                    handled = base.ControlProc(hWndParent, hWndControl, controlId, command, wParam, lParam);
                    break;
            }

            return handled;

        }

        public bool Checked
        {
            get
            {
                if(this.ParentHandle != IntPtr.Zero)
                {
                    uint check = User32.IsDlgButtonChecked(this.ParentHandle, this.ControlId);
                    if(check==1) 
                        this._Checked = true;
                    else
                        this._Checked = false;
                }

                return this._Checked;

            }

            set
            {
                this._Checked = value;
                if(this.ParentHandle != IntPtr.Zero)
                {
                    uint check = 0;
                    if(this._Checked) check = 1;
                    User32.CheckDlgButton(this.ParentHandle,this.ControlId, check);
                }
            }
        }
    }
}