using Diga.Core.Api.Win32;
using System;
using System.Diagnostics;
using System.Text;

namespace CoreWindowsWrapper
{
    public class NativeListBox : NativeControlBase
    {
        public event EventHandler<EventArgs> SelChange;
        public new event EventHandler<EventArgs> DblClicked;
        public event EventHandler<EventArgs> SelCancel;
        public event EventHandler<EventArgs> SetFocus;
        public event EventHandler<EventArgs> KillFocus;
        public bool MultiSelect{get;set;} = false;
        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.ListBox;
            this.TypeIdentifier = "listbox";
            this.ClientEdge = true;
            this.Style |= ListBoxStyle.LBS_STANDARD;
           

        }
        //protected override void AfterCreate()
        //{
        //    base.AfterCreate();
        //    NativeTheaming.SetThemaing(this.Handle);
        //}
        public override bool Create(IntPtr parentId)
        {
            if (this.MultiSelect)
            {
                this.Style |= ListBoxStyle.LBS_EXTENDEDSEL | ListBoxStyle.LBS_MULTIPLESEL;
            }
            return base.Create(parentId);
        }
        public int GetSelCount()
        {
            IntPtr retVal = User32.SendMessage(this.Handle, ListBoxMessages.LB_GETSELCOUNT, IntPtr.Zero, IntPtr.Zero);
            return retVal.ToInt32();
        }

        public bool IsItemSelected(int index)
        {
            IntPtr retVal = User32.SendMessage(this.Handle, ListBoxMessages.LB_GETSEL, index, 0);
            int value = retVal.ToInt32();
            if (value == ListBoxMessages.LB_ERR)
                Debug.Print("Error => IsItemSelected");
            return value > 0;
        }
        public int CurrentSelected()
        {
            IntPtr result = User32.SendMessage(this.Handle, ListBoxMessages.LB_GETCURSEL, IntPtr.Zero, IntPtr.Zero);
            int index = result.ToInt32();
            return index;
        }

        public void SetSelectionRange(int firstIndex, int lastIndex)
        {
            if (this.MultiSelect)
            {
                IntPtr retVal = User32.SendMessage(this.Handle, ListBoxMessages.LB_SELITEMRANGEEX , firstIndex,lastIndex);
                if (retVal.ToInt32() == ListBoxMessages.LB_ERR)
                    throw new Exception("Cannot select the Index");
            }
            else
            {
                IntPtr retVal = User32.SendMessage(this.Handle, ListBoxMessages.LB_SETCURSEL, lastIndex, 0);
                if (retVal.ToInt32() == ListBoxMessages.LB_ERR)
                    throw new Exception("Cannot select the Index");
            }
        }
        public void SetCurrentSelected(int index)
        {
            if (this.MultiSelect)
            {
                IntPtr retVal = User32.SendMessage(this.Handle, ListBoxMessages.LB_SELITEMRANGEEX , index-1,index);
                if (retVal.ToInt32() == ListBoxMessages.LB_ERR)
                    throw new Exception("Cannot select the Index");
                retVal = User32.SendMessage(this.Handle, ListBoxMessages.LB_SELITEMRANGEEX, index - 1, index - 1);
                if (retVal.ToInt32() == ListBoxMessages.LB_ERR)
                    throw new Exception("Cannot select the Index");
                
            }
            else
            {
                IntPtr retVal = User32.SendMessage(this.Handle, ListBoxMessages.LB_SETCURSEL, index, 0);
                if (retVal.ToInt32() == ListBoxMessages.LB_ERR)
                    throw new Exception("Cannot select the Index");

            }
        }
        public string GetItemText(int index)
        {
            StringBuilder sb = new StringBuilder(255);
            IntPtr retVal = User32.SendMessage(this.Handle, ListBoxMessages.LB_GETTEXT, index, sb);
            if (retVal.ToInt32() == ListBoxMessages.LB_ERR)
                throw new Exception("Cannot find Item");
            return sb.ToString();
        }
        public int Count()
        {
            IntPtr result = User32.SendMessage(this.Handle, ListBoxMessages.LB_GETCOUNT, IntPtr.Zero, IntPtr.Zero);
            int value = result.ToInt32();
            if (value == ListBoxMessages.LB_ERR)
                Debug.Print("Error in ListBox-Count");
            return value;
        }
        public int AddText(string textToAdd)
        {
            IntPtr retVal = User32.SendMessage(this.Handle, ListBoxMessages.LB_ADDSTRING, 0, textToAdd);
            int value = retVal.ToInt32();
            if (value == ListBoxMessages.LB_ERR)
                throw new Exception("Could not add Element!");
            if (value == ListBoxMessages.LB_ERRSPACE)
                throw new Exception("Insufficient Space to add Data");
            return value;
        }

        protected override bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
            Debug.Print("ListBox-Commands=>" + command);
            bool result = false;
            switch (command)
            {
                case ListBoxNotify.LBN_SELCHANGE:
                    OnSelChange();
                    result = true;
                    break;
                case ListBoxNotify.LBN_DBLCLK:
                    OnDblClicked();
                    result = true;
                    break;
                case ListBoxNotify.LBN_SELCANCEL:
                    OnSelCancel();
                    result = true;
                    break;
                case ListBoxNotify.LBN_SETFOCUS:
                    OnSetFocus();
                    result = true;
                    break;
                case ListBoxNotify.LBN_KILLFOCUS:
                    OnKillFocus();
                    result = true;
                    break;
                
            }
            return result;
        }

        public void Clear()
        {
            User32.SendMessage(this.Handle, ListBoxMessages.LB_RESETCONTENT, 0, 0);
        }

        protected virtual void OnSelChange()
        {
            SafeInvoke(SelChange, EventArgs.Empty);
        }

        protected override void OnDblClicked()
        {
            SafeInvoke(DblClicked, EventArgs.Empty);
        }

        protected virtual void OnSelCancel()
        {
            SafeInvoke(SelCancel, EventArgs.Empty);
        }

        protected virtual void OnSetFocus()
        {
            SafeInvoke(SetFocus, EventArgs.Empty);
        }

        protected virtual void OnKillFocus()
        {
            SafeInvoke(KillFocus, EventArgs.Empty);
        }
    }
}