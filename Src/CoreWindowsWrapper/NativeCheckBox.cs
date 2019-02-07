using System;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeCheckBox:NativeButton
    {
        private bool _Checked;
        protected override void Initialize()
        {
            base.Initialize();
            this.Style = this.Style |ButtonStyles.BS_CHECKBOX;
            
        }

        protected override void AfterCreate()
        {
            base.AfterCreate();
            this.Checked = this._Checked;
        }

        protected override bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
            uint check = Win32Api.IsDlgButtonChecked(hWndParent, controlId);
            if(check == 1)
                Win32Api.CheckDlgButton(hWndParent, controlId,0);
            else
                Win32Api.CheckDlgButton(hWndParent,controlId,1);
            
            return base.ControlProc(hWndParent, hWndControl, controlId, command, wParam, lParam);

        }

        public bool Checked
        {
            get
            {
                if(this.ParentHandle != IntPtr.Zero)
                {
                    uint check = Win32Api.IsDlgButtonChecked(this.ParentHandle, this.ControlId);
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
                    Win32Api.CheckDlgButton(this.ParentHandle,this.ControlId, check);
                }
            }
        }
    }
}