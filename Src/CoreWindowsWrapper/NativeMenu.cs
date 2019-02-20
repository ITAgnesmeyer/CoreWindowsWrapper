using System;
using System.Collections.Generic;
using System.Text;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeMenu:IMenuItem
    {
        internal int Id{get=> ((IMenuItem)this).Id;set=> ((IMenuItem)this).Id =value;}
        public IntPtr Handle { get; set; }
        public string Name{get;set;}
        public string Text{get;set;}
        internal IntPtr ParentMenuHandle{get=>((IMenuItem)this).ParentMenuHandle;set=>((IMenuItem)this).ParentMenuHandle = value;}
        int IMenuItem.Id { get; set; }
        IntPtr IMenuItem.ParentMenuHandle { get; set; }
        public MenuItemCollection Items { get; internal set; } = new MenuItemCollection();

        public NativeMenu()
        {
            Win32ApiForm.Win32Control.LastControlId= Win32ApiForm.Win32Control.LastControlId + 1;
            this.Id = Win32ApiForm.Win32Control.LastControlId;
            this.Text = "";
            this.Name = "";
        }

        public NativeMenu(string name, string text) : this()
        {
            this.Text = text;
            this.Name = name;
        }

        public NativeMenu(string text):this(text,text)
        { }

        public void Create()
        {
            Create(IntPtr.Zero);
        }
        public virtual void Create(IntPtr parentMenuHandle)
        {
            this.ParentMenuHandle = parentMenuHandle;
            this.Handle = Win32Api.CreateMenu();
            if (this.ParentMenuHandle == IntPtr.Zero)
            {
                this.ParentMenuHandle = Win32Api.CreateMenu();
            }


            Win32Api.AppendMenu(this.ParentMenuHandle, MenuStyles.MF_STRING | MenuStyles.MF_POPUP , (uint) this.Handle, this.Text);
            foreach (IMenuItem itemsValue in this.Items.Values)
            {
                if (itemsValue is NativeMenu )
                {
                    itemsValue.Create(this.ParentMenuHandle);
                }
                else
                {
                    itemsValue.Create(this.Handle);
                }


                    
            }
            
        }
        protected virtual bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command,
            IntPtr wParam, IntPtr lParam)
        {
            return false;
        }
        public bool HandleEvents(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
            return ControlProc(hWndParent, hWndControl, controlId, command, wParam, lParam);
        }


        public virtual void Destroy()
        {
           //
        }
    }
}
