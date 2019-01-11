using System;
using CoreWindowsWrapper.Api.Win32;
using CoreWindowsWrapper.Win32ApiForm;

namespace CoreWindowsWrapper
{
    public class NativeControlBase : IControl
    {
        private Win32Control _Control;
        public virtual  event EventHandler Clicked;
        public virtual  event EventHandler DblClicked;
        public NativeControlBase()
        {
            Initialize();
        }


        protected virtual  void Initialize()
        {
            this._Control = new Win32Control();

        }

        internal uint Style
        {
            get => this._Control.Style;
            set => this._Control.Style = value;
        }
        internal virtual void Show(IntPtr parentHandle)
        {
            this._Control.Create(parentHandle);
        }

        internal string TypeBezeichner
        {
            get => this._Control.TypeBezeichner;
            set => this._Control.TypeBezeichner = value;
        }

        internal CommonControls CommonControlType
        {
            get => this._Control.CommonControType;
            set => this._Control.CommonControType = value;
        }

        public IntPtr Handle
        {
            get
            {
                if (this._Control != null)
                {
                    return this._Control.Handle;
                }

                return IntPtr.Zero;
            }
        }

        public IntPtr ParentHandle
        {
            get => this._Control.ParentHandle;
            set => this._Control.ParentHandle = value;
        }

        public string Name
        {
            get => this._Control.Name;
            set => this._Control.Name = value;
        }

        public virtual  string Text
        {
            get => this._Control.Text;
            set => this._Control.Text = value;
        }

        public int BackColor
        {
            get { return this._Control.BackColor; }
            set { this._Control.BackColor = value; }
        }

        public int Left
        {
            get => this._Control.Left;
            set => this._Control.Left = value;
        }

        public int Top
        {
            get => this._Control.Top;
            set => this._Control.Top = value;
        }

        public int Width
        {
            get => this._Control.Width;
            set => this._Control.Width = value;
        }

        public int Height
        {
            get => this._Control.Height;
            set => this._Control.Height = value;
        }

        public Point Location
        {
            get => this._Control.Location;
            set => this._Control.Location = value;
        }

        public int ControlId
        {
            get => this._Control.ControlId;
            set => this._Control.ControlId = value;
        }

        public bool Create(IntPtr parentId)
        {
            return this._Control.Create(parentId);
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

        protected virtual void OnClicked()
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnDblClicked()
        {
            DblClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}