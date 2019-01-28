﻿using System;
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

                    IntPtr v = Win32Api.SendMessage(this.Handle, (int) ProgressBarMessages.PBM_GETPOS, 0,
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
}