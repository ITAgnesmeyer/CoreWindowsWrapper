using System;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeProgress : NativeControlBase
    {
        private int _Value;
        private int _MaxValue;

        protected override void Initialize()
        {
            base.Initialize();
            this.TypeBezeichner = "msctls_progress32";
            this.CommonControlType = CommonControls.ICC_PROGRESS_CLASS;
            this.Style = this.Style | ProgressBarStyles.PBS_SMOOTH;
          
        }

        public int MaxValue
        {
            get
            {
                if (this.Handle == IntPtr.Zero)
                {
                    return this._MaxValue;
                }
                else
                {
                    int lP = Win32Api.LoWord(1);
                    Win32Api.SendMessage(this.Handle, (int) ProgressBarMessages.PBM_GETRANGE,lP, out var hiLow);



                    this._MaxValue = Win32Api.LoWord(hiLow.iHigh);
                    return this._MaxValue;
                }
            }
            set
            {
                this._MaxValue = value;
                HighLow hiLow = new HighLow {iHigh = this.MaxValue, iLow = 0};
                Win32Api.SendMessage(this.Handle, (int) ProgressBarMessages.PBM_SETRANGE, 0, hiLow);

            }
        }
        public int Value
        {
            get
            {
                if (this.Handle == IntPtr.Zero)
                {
                    return this._Value;
                }
                else
                {

                    IntPtr v = Win32Api.SendMessage(this.Handle, (int) ProgressBarMessages.PBM_GETPOS, (int) 0,
                        IntPtr.Zero);
                    this._Value = (int) v;
                    return this._Value;
                }
            }
            set
            {
                this._Value = value;
                Win32Api.SendMessage(this.Handle, (int) ProgressBarMessages.PBM_SETPOS, value, IntPtr.Zero);

            }
        }
    }
    public class NativeButton : NativeControlBase
    {
        public override event EventHandler Clicked;
        public override event EventHandler DblClicked;
      

        protected override void Initialize()
        {
            base.Initialize();
            this.TypeBezeichner = "button";
            this.Style = this.Style |  ButtonStyples.BS_PUSHBUTTON | ButtonStyples.BS_FLAT;
            

        }

        protected override bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
            bool handeld = false;
            switch (command)
            {
                case ButtonMessages.BN_CLICKED:
                    OnClicked();
                    handeld = true;
                    break;
                case ButtonMessages.BN_DBLCLK:
                    OnDblClicked();
                    break;
            }

            return handeld;
        }


        protected override void OnClicked()
        {
            this.Clicked?.Invoke(this, EventArgs.Empty); 
        }

        protected override void OnDblClicked()
        {
            this.DblClicked?.Invoke(this,EventArgs.Empty);
        }
    }
}