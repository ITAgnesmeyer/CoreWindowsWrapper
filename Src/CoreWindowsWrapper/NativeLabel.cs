using System;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeLabel : NativeControlBase
    {


        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.Label;
            this.TypeIdentifier = "static";
            this.Style = WindowStylesConst.WS_VISIBLE | WindowStylesConst.WS_CHILD | StaticControlStyles.SS_NOTIFY;
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
                case StaticControlMessages.STN_DBLCLK:

                    OnDblClicked();
                    handled = true;
                    break;
                case StaticControlMessages.STN_CLICKED:
                    OnClicked();
                    handled = true;
                    break;


            }

            return handled;
        }


    }
}