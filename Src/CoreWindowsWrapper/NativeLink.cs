using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper
{
    public class NativeLink : NativeControlBase
    {
        private const uint NM_FIRST = unchecked(0U - 0U);
        private const uint NM_CLICK = unchecked(NM_FIRST - 2);
        public event EventHandler<NativeLinkClickEventArgs> LinkClicked;
        protected override void Initialize()
        {
            base.Initialize();
            this.TypeIdentifier = "SysLink";
            this.CommonControlType = Api.Win32.CommonControls.ICC_LINK_CLASS;
           

        }

        protected override bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
            bool handled = false;
            switch (command)
            {
                case NM_CLICK:
                    Api.Win32.NMLINK link = Marshal.PtrToStructure<Api.Win32.NMLINK>(lParam);
                    if (link != null)
                    {
                        if (link.item != null)
                        {
                            string id = link.item.szID;
                            string linUlr = new string(link.item.szUrl);
                            OnLinkClicked(new NativeLinkClickEventArgs(id, linUlr));
                        }
                    }
                    handled = true;
                    break;

            }

            return handled;
        }

        protected virtual void OnLinkClicked(NativeLinkClickEventArgs e)
        {
            SafeInvoke(this.LinkClicked, e);

        }
    }
}