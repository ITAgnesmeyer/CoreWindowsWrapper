using Diga.Core.Api.Win32;
using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper
{
    public class NativeLink : NativeControlBase
    {
      
        public event EventHandler<NativeLinkClickEventArgs> LinkClicked;
        protected override void Initialize()
        {
            base.Initialize();
            this.ControlType = Win32ApiForm.ControlType.Link;
            this.TypeIdentifier = "SysLink";
            this.CommonControlType = CommonControls.ICC_LINK_CLASS;
           

        }

        protected override bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
            bool handled = false;
            switch (command)
            {
                case NotifyMessageConst.NM_CLICK:
                    NmlInk link = Marshal.PtrToStructure<NmlInk>(lParam);
                    if (link != null)
                    {
                        if (link.item != null)
                        {
                            string id = link.item.szID;
                            string linkUrl = link.item.szUrl;
                            string linUlr = linkUrl;
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