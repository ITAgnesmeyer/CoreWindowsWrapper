using System;
using System.CodeDom;
using System.Diagnostics;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeTextBox : NativeControlBase
    {
        private const uint ECM_FIRST = 0x1500;
        private const uint EM_SETEXTENDEDSTYLE = ECM_FIRST + 10;
        private const uint ES_EX_ALLOWEOL_CR = 0x0001;
        private const uint ES_EX_ALLOWEOL_LF = 0x0002;
        private const uint ES_EX_ALLOWEOL_ALL = (ES_EX_ALLOWEOL_CR | ES_EX_ALLOWEOL_LF);
        private const uint ES_EX_CONVERT_EOL_ON_PASTE = 0x0004;
        private const uint ES_EX_ZOOMABLE = 0x0010;
        public event EventHandler<EventArgs> Change;
        public event EventHandler<EventArgs> SetFocus;
        public event EventHandler<EventArgs> KillFocus;
        
        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.Edit;
            this.TypeIdentifier = "Edit";
            this.Style |= EditBoxStyles.ES_AUTOHSCROLL | EditBoxStyles.ES_WANTRETURN | WindowStylesConst.WS_BORDER  ;
            
            this.BackColor = Tools.ColorTool.White;
            this.ForeColor = Tools.ColorTool.Black;

        }
        protected override void AfterCreate()
        {
            base.AfterCreate();

            //NativeTheaming.SetThemaing(this.Handle);

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
       
        public bool IsReadOnly => (this.GetWindowStyle() & EditBoxStyles.ES_READONLY) == EditBoxStyles.ES_READONLY;

        public bool ReadOnly { 
            get 
            { 
                return this.IsReadOnly;  
            }
            set
            {
                if(value == true )
                {
                    User32.SendMessage(this.Handle, EditBoxMessages.EM_SETREADONLY, 1, 0);
                }
                else
                {
                    User32.SendMessage(this.Handle, EditBoxMessages.EM_SETREADONLY, 0, 0);
                }

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
        protected override void OnKeyDown(IntPtr hWnd, NativeKeyEventArgs keyEventArgs)
        {
            if(keyEventArgs.Key == VirtualKeys.VK_TAB)
            {
                keyEventArgs.Handled = true;
                keyEventArgs.ResturnCode = (IntPtr)0x0002;
                User32.PostMessage(this.ParentHandle, WindowsMessages.WM_KEYDOWN, (IntPtr)keyEventArgs.Key,(IntPtr)0);
                return;
            }
            base.OnKeyDown(hWnd, keyEventArgs);
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