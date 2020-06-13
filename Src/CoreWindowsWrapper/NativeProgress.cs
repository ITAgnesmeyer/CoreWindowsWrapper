using System;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeProgress : NativeControlBase
    {
        private int _Value;
        private int _MaxValue;

        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.Progress;
            this.TypeIdentifier = "msctls_progress32";
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
                    User32.SendMessage(this.Handle, (int) ProgressBarMessages.PBM_GETRANGE,lP, out var hiLow);



                    this._MaxValue = Win32Api.LoWord((int)hiLow.iHigh);
                    return this._MaxValue;
                }
            }
            set
            {
                this._MaxValue = value;
                HighLow hiLow = new HighLow {iHigh =this.MaxValue, iLow = 0};
                User32.SendMessage(this.Handle, (int) ProgressBarMessages.PBM_SETRANGE, 0, hiLow);

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

                    IntPtr v = User32.SendMessage(this.Handle, (int) ProgressBarMessages.PBM_GETPOS, 0,
                        IntPtr.Zero);
                    this._Value = (int) v;
                    return this._Value;
                }
            }
            set
            {
                this._Value = value;
                User32.SendMessage(this.Handle, (int) ProgressBarMessages.PBM_SETPOS, value, IntPtr.Zero);

            }
        }
    }
}