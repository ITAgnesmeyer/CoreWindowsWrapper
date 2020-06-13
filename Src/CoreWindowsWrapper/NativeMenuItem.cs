using System;
using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeMenuItem : IMenuItem
    {

        public event EventHandler<MouseClickEventArgs> Click;
        internal int Id { get => ((IMenuItem)this).Id; set => ((IMenuItem)this).Id = value; }
        public IntPtr Handle { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public bool IsSeparator{get;set;}
        internal IntPtr ParentMenuHandle { get => ((IMenuItem)this).ParentMenuHandle; set => ((IMenuItem)this).ParentMenuHandle = value; }
        int IMenuItem.Id { get; set; }
        IntPtr IMenuItem.ParentMenuHandle { get; set; }
        public MenuItemCollection Items { get; internal set; } = new MenuItemCollection();

        public NativeMenuItem()
        {
            Win32ApiForm.Win32Control.LastControlId = Win32ApiForm.Win32Control.LastControlId + 1;
            this.Id = Win32ApiForm.Win32Control.LastControlId;
            this.Text = "";
            this.Name = "";
        }

        
        public NativeMenuItem(string name, string text ):this()
        {
            this.Name = name;
            this.Text = text;
        }

        public NativeMenuItem(string text) : this(text, text)
        {

        }
        public virtual void Create(IntPtr parentMenuHandle)
        {
            uint flag = MenuStyles.MF_STRING;
            if (this.IsSeparator)
                flag = MenuStyles.MF_SEPARATOR;
            this.ParentMenuHandle = parentMenuHandle;
            if (this.ParentMenuHandle == IntPtr.Zero)
            {
                this.Handle = User32.CreateMenu();
               
                User32.AppendMenu(this.Handle, flag, (uint) this.Id, this.Text);
                foreach (IMenuItem subItemns in this.Items.Values)
                {
                    subItemns.Create(this.Handle);
                }

            }
            else
            {
                User32.AppendMenu(this.ParentMenuHandle,flag, (uint) this.Id, this.Text);
                foreach (IMenuItem subItems in this.Items.Values)
                {
                    subItems.Create(this.ParentMenuHandle);
                }

            }

            
        }

        protected virtual bool ControlProc(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command,
            IntPtr wParam, IntPtr lParam)
        {
            
                OnClick(new MouseClickEventArgs(MouseButton.Left, hWndControl));

            return true;
        }
        public bool HandleEvents(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
            return ControlProc(hWndParent, hWndControl, controlId, command, wParam, lParam);
        }


        public virtual void Destroy()
        {
            
        }
        protected void SafeInvoke<T>(EventHandler<T> eventHandler, T ars) where T:EventArgs
        {
            try
            {
                eventHandler?.Invoke(this, ars);
            }
            catch (Exception e)
            {
                MessageBox.Show("Event Error:" + e.Message);
            }
        }

        protected virtual void OnClick(MouseClickEventArgs e)
        {
            SafeInvoke(Click, e); 
 

        }
    }
}