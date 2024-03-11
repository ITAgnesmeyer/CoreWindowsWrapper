using System;
using System.Text;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{

    public class NativeComboBox : NativeControlBase
    {
        public event EventHandler<NativeComboBoxSelChangeEventArgs> SelChange;
        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.ComboBox;
            this.TypeIdentifier = "combobox";
           
            this.Style = ComboBoxStyles.CBS_DROPDOWN | ComboBoxStyles.CBS_HASSTRINGS |WindowStylesConst.WS_CHILD | WindowStylesConst.WS_OVERLAPPED | WindowStylesConst.WS_VISIBLE | WindowStylesConst.WS_TABSTOP;
        }
        //protected override void AfterCreate()
        //{
        //    base.AfterCreate();
        //    NativeTheaming.SetThemaing(this.Handle);
        //}
        protected override bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {

            bool handled = false;

            switch (command)
            {
                case ComboBoxMessages.CBN_SELCHANGE:
                    int selIndex = this.SelectedIndex;
                    NativeComboBoxSelChangeEventArgs evItem = new NativeComboBoxSelChangeEventArgs(selIndex);
                    OnSelChange(evItem);
                    handled = true;
                    break;
            }


            return handled;
        }

        public void Add(string addString)
        {
            User32.SendMessage(this.Handle, ComboBoxCommands.CB_ADDSTRING, 0, addString);
        }

        public int SelectedIndex
        {
            get
            {
                int selected = User32.SendMessage(this.Handle, ComboBoxCommands.CB_GETCURSEL, 0, 0).ToInt32();
                return selected;
            }
            set
            {
                User32.SendMessage(this.Handle, ComboBoxCommands.CB_SETCURSEL, value, (int)0);
            }
        }

        public int ItemsCount()
        {
            return User32.SendMessage(this.Handle, ComboBoxCommands.CB_GETCOUNT, 0, 0).ToInt32();
        }

        public string ItemText(int index)
        {
            StringBuilder sb = new StringBuilder();
            User32.SendMessage(this.Handle, ComboBoxCommands.CB_GETLBTEXT, index, sb);
            return sb.ToString();
        }

        protected virtual void OnSelChange(NativeComboBoxSelChangeEventArgs e)
        {
            SafeInvoke(this.SelChange, e);
        }
    }
}