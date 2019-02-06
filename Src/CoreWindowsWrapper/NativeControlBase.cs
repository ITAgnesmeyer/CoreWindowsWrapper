using System;
using CoreWindowsWrapper.Api.Win32;
using CoreWindowsWrapper.Win32ApiForm;

namespace CoreWindowsWrapper
{

    public class NativeControlBase : IControl
    {
        private Win32Control _Control;
        internal virtual Win32Control Control { get => this._Control; set => this._Control = value; }
        public virtual event EventHandler Clicked;
        public virtual event EventHandler DblClicked;
        private Font _Font;
        public NativeControlBase()
        {
            this.Font = new Font();
            Initialize();
        }


        protected virtual void Initialize()
        {
            this.Control = new Win32Control();
            this.Control.Font = this._Font;

        }

        internal uint Style
        {
            get => this.Control.Style;
            set => this.Control.Style = value;
        }
        internal virtual void Show(IntPtr parentHandle)
        {
            this.Control.Create(parentHandle);
        }

        internal string TypeIdentifier
        {
            get => this.Control.TypeIdentifyer;
            set => this.Control.TypeIdentifyer = value;
        }

        internal CommonControls CommonControlType
        {
            get => this.Control.CommonControType;
            set => this.Control.CommonControType = value;
        }

        public IntPtr Handle
        {
            get
            {
                if (this.Control != null)
                {
                    return this.Control.Handle;
                }

                return IntPtr.Zero;
            }
        }

        public IntPtr ParentHandle
        {
            get => this.Control.ParentHandle;
            set => this.Control.ParentHandle = value;
        }

        public string Name
        {
            get => this.Control.Name;
            set => this.Control.Name = value;
        }

        public virtual string Text
        {
            get => this.Control.Text;
            set => this.Control.Text = value;
        }

        public int BackColor
        {
            get => this.Control.BackColor;
            set => this.Control.BackColor = value;
        }

        public int Left
        {
            get => this.Control.Left;
            set => this.Control.Left = value;
        }

        public int Top
        {
            get => this.Control.Top;
            set => this.Control.Top = value;
        }

        public int Width
        {
            get => this.Control.Width;
            set => this.Control.Width = value;
        }

        public int Height
        {
            get => this.Control.Height;
            set => this.Control.Height = value;
        }

        public Point Location
        {
            get => this.Control.Location;
            set => this.Control.Location = value;
        }

        internal int ControlId
        {
            get => ((IControl)this).ControlId;
            set => ((IControl)this).ControlId = value;
        }
        int IControl.ControlId
        {
            get => this.Control.ControlId;
            set => this.Control.ControlId = value;
        }

        public int ForeColor
        {
            get => this.Control.ForeColor;
            set => this.Control.ForeColor = value;
        }
        public Font Font
        {
            get
            {
                Font f = this._Font;
                if(this.Control!= null)
                {
                    f = this.Control.Font;
                    if(!f.Equals(this._Font))
                    {
                        this._Font = f;
                    }
                }
                return f;
            }
            set
            {   
                this._Font = value;
                if(this.Control!= null)
                {
                    this.Control.Font = this._Font;
                }
                
            }
        }

        public virtual bool Create(IntPtr parentId)
        {
            return this.Control.Create(parentId);
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

        public virtual void Destroy()
        {
            Console.Write("on Destroy");
        }
    }
}