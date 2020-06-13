using System;
using System.Text;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeRichTextBox : NativeControlBase
    {
        private string _Text;
        protected override void Initialize()
        {
            Kernel32.LoadLibrary("Msftedit.dll");
            base.Initialize();
            this.TypeIdentifier = "RICHEDIT50W";

            this.Style = this.Style | EditBoxStyles.ES_MULTILINE | WindowStylesConst.WS_HSCROLL | WindowStylesConst.WS_VSCROLL;

        }

        public override string Text
        {
            get
            {
                if (this.Handle != IntPtr.Zero)
                {
                    IntPtr size = User32.SendMessage(this.Handle, WindowsMessages.WM_GETTEXTLENGTH, 0, 0);
                    int len = size.ToInt32();
                    StringBuilder sb = new StringBuilder(len + 1);
                    User32.SendMessage(this.Handle, (int)WindowsMessages.WM_GETTEXT, sb.Capacity, sb);
                    this._Text = sb.ToString();
                }
                return this._Text;
            }
            set
            {
                this._Text = value;
                if (this.Handle != IntPtr.Zero)
                {
                    User32.SendMessage(this.Handle, (int)WindowsMessages.WM_SETTEXT, IntPtr.Zero, this._Text);
                }
            }
        }

        public override bool Create(IntPtr parentId)
        {
            bool retVal = base.Create(parentId);
            User32.SendMessage(this.Handle, RichEditMessages.EM_EXLIMITTEXT, 0, uint.MaxValue);
            return retVal;

        }
    }
}