using Diga.Core.Api.Win32;
using System;

namespace CoreWindowsWrapper
{
    public class NativeDateTimePicker : NativeControlBase
    {
        private const uint DTN_FIRST2 = 0xfffffd0f;
        private const uint DTN_DATETIMECHANGE = (DTN_FIRST2 - 6);
        public event EventHandler<EventArgs> SetFocus;
        public event EventHandler<EventArgs> KillFocus;
        public event EventHandler<EventArgs> Change;
        protected override void Initialize()
        {
            base.Initialize();
            this.TypeIdentifier = "SysDateTimePick32";
            //this.Style |= 0x000C | 0x0009;
        }

        protected override bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
            bool handled = false;
            switch (command)
            {
                case NotifyMessageConst.NM_SETFOCUS:
                    OnSetFocus();
                    handled = true;
                    break;
                case NotifyMessageConst.NM_KILLFOCUS:
                    OnKillFocus();
                    handled = true;
                    break;
                case DTN_DATETIMECHANGE:
                    OnChange();
                    handled = true;
                    break;

            }

            return handled;
        }

        public DateTime Value 
        { 
            get 
            {
                int retVal = DateTimePickerMessages.DateTime_GetSystemtime(this.Handle, out SystemTime time);
                if(retVal == 0)
                {
                    return time;
                }
                else
                {
                    return DateTime.MinValue;
                }
            } 
            set 
            { 
                DateTimePickerMessages.DateTime_SetSystemtime(this.Handle, value);
            } 
        }
        protected virtual void OnChange()
        {
            SafeInvoke(this.Change , EventArgs.Empty);
        }
        protected virtual void OnKillFocus()
        {
            SafeInvoke(this.KillFocus, EventArgs.Empty);
        }
        protected virtual void OnSetFocus()
        {
            SafeInvoke(this.SetFocus, EventArgs.Empty);
        }
    }
}