﻿using System;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeTextBox : NativeControlBase
    {
        public event EventHandler<EventArgs> Change;
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
            switch (command)
            {
                case EditBoxMessages.EN_CHANGE:
                    OnChange();
                    handled = true;
                    break;


            }

            return handled;

        }

        protected virtual void OnChange()
        {
            //Change?.Invoke(this, EventArgs.Empty);
            SafeInvoke(this.Change, EventArgs.Empty);
        }
    }
}