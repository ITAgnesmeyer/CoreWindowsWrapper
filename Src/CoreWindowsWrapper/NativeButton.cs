using System;
using System.Diagnostics;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeButton : NativeControlBase
    {
        public override event EventHandler<EventArgs> Clicked;
        public override event EventHandler<EventArgs> DblClicked;
      

        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.Button;
            this.TypeIdentifier = "button";
            this.Style = this.Style |  ButtonStyles.BS_PUSHBUTTON | ButtonStyles.BS_FLAT | ButtonStyles.BS_NOTIFY;
            

        }

        protected override bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
            bool handeld = false;
           
            switch (command)
            {
                case ButtonMessages.BN_SETFOCUS:
                    Debug.Print("ButtonControl:BN_SETFOCUS");
                    break;
                case ButtonMessages.BN_KILLFOCUS:
                    Debug.Print("ButtonControl:BN_KILLFOCUS");
                    break;
                case ButtonMessages.BN_CLICKED:
                    OnClicked();
                    handeld = true;
                    break;
                case ButtonMessages.BN_DBLCLK:
                    OnDblClicked();
                    handeld = true;
                    break;
            }

            return handeld;
        }


        protected override void OnClicked()
        {
            //Clicked?.Invoke(this, EventArgs.Empty); 
            SafeInvoke(this.Clicked, EventArgs.Empty);
        }

        protected override void OnDblClicked()
        {
            //DblClicked?.Invoke(this,EventArgs.Empty);
            SafeInvoke(this.DblClicked, EventArgs.Empty);
        }
    }
}