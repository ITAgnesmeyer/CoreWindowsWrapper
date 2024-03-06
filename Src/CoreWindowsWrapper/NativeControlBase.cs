using System;
using System.Threading.Tasks;
using Diga.Core.Api.Win32;
using CoreWindowsWrapper.Win32ApiForm;

namespace CoreWindowsWrapper
{
    //[Flags]
    //public enum AnchorType:uint
    //{
    //    None = 0x0000,
    //    Left = WindowsMessages.WM_USER + 
    //}

    public class NativeControlBase : IControl
    {
        private Win32Control _Control;
        internal virtual Win32Control Control { get => this._Control; set => this._Control = value; }
        public virtual event EventHandler<EventArgs> Clicked;
        public virtual event EventHandler<EventArgs> DblClicked;
        public virtual event EventHandler<NativeKeyEventArgs> KeyDown;
        public virtual event EventHandler<NativeKeyEventArgs> KeyUp;
        public virtual event EventHandler<NativeKeyEventArgs> KeyPress;
        //public virtual event EventHandler<NativeKeyEventArgs> KeyUp; 
        public event EventHandler<MouseMoveEventArgs> MouseMove;
        private Font _Font;
        private readonly TaskQueue _TaskQueue = new TaskQueue();

        public NativeControlBase()
        {
            this.Font = new Font();
            this.ControlType = ControlType.DefaultControl;
            // ReSharper disable once VirtualMemberCallInConstructor
            Initialize();
        }


        protected virtual void Initialize()
        {
            this.Control = new Win32Control {Font = this._Font, BackColor = 0xF0F0F0};

        }

        protected virtual void AfterCreate()
        {

        }
        public uint Style
        {
            get => this.Control.Style;
            set => this.Control.Style = value;
        }
        internal virtual void Show(IntPtr parentHandle)
        {
            this.Control.Create(parentHandle);
        }

        public string TypeIdentifier
        {
            get => this.Control.TypeIdentifyer;
            set => this.Control.TypeIdentifyer = value;
        }

        protected CommonControls CommonControlType
        {
            get => this.Control.CommonControlType;
            set => this.Control.CommonControlType = value;
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

        public bool Visible
        {
            get => this.Control.Visible;
            set => this.Control.Visible = value;
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
        public Size Size
        {
            get => this.Control.Size;
            set => this.Control.Size = value;
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
        internal bool ClientEdge
        {
            get => ((IControl)this).ClientEdge;
            set => ((IControl)this).ClientEdge = value;
        }
        bool IControl.ClientEdge { get => this.Control.ClientEdge; set => this.Control.ClientEdge = value; }
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
                if (this.Control != null)
                {
                    f = this.Control.Font;
                    if (!f.Equals(this._Font))
                    {
                        this._Font = f;
                    }
                }
                return f;
            }
            set
            {
                this._Font = value;
                if (this.Control != null)
                {
                    this.Control.Font = this._Font;
                }

            }
        }


        private int _DiffLeft=0;
        private int _DiffTop=0;
        private int _DiffRight = 0;
        private int _DiffBottom = 0;
        public virtual bool Create(IntPtr parentId)
        {
            bool retCreate = this.Control.Create(parentId);
            this.AfterCreate();
            this.Control.WndProc = OnWndProc;
            if(User32.GetClientRect(parentId, out Rect pRect))
            {
                _DiffLeft = this.Left;
                _DiffTop = this.Top;
                _DiffRight = pRect.Width - (this.Left + this.Width); 
                _DiffBottom = pRect.Height - (this.Top + this.Height);
            }

            return retCreate;
        }

        private IntPtr OnWndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
        {
            switch(msg)
            {
                case WindowsMessages.WM_KEYDOWN:
                    {
                        var kevDown = new NativeKeyEventArgs(wParam, lParam);
                        OnKeyDown(hWnd, kevDown);
                        if (kevDown.Handled)
                        {
                            if(kevDown.ResturnCode != IntPtr.Zero)
                                return kevDown.ResturnCode;
                            return (IntPtr)1;
                        }
                            

                    }
                    break;
                case WindowsMessages.WM_MOUSEMOVE:
                    HighLow hl = Win32Api.MakeHiLo(lParam);
                    uint mouseButtons = Win32Api.GetIntPtrUInt(wParam);
                    OnMouseMove(new MouseMoveEventArgs(new Point(hl.iLow, hl.iHigh), (MouseKey)mouseButtons));
                    break;
                case WindowsMessages.WM_KEYUP:
                    {
                        var kevUp = new NativeKeyEventArgs(wParam, lParam);
                        OnKeyUp(hWnd, kevUp);
                        if(kevUp.Handled)
                            return (IntPtr)1;
                    }
                    break;
                case WindowsMessages.WM_CHAR:
                    {
                        var kevDown = new NativeKeyEventArgs(wParam, lParam);
                        OnKeyPress(hWnd, kevDown);
                        if(kevDown.Handled)
                            return (IntPtr)1;
                    }
                    break;
            }
            return IntPtr.Zero;
        }
        protected virtual void OnMouseMove(MouseMoveEventArgs e)
        {
            SafeInvoke(this.MouseMove, e);
            
        }
        protected virtual void OnKeyPress(IntPtr hWnd, NativeKeyEventArgs keyEventArgs)
        {
            SafeInvoke(this.KeyPress, keyEventArgs);
        }
        protected  virtual void OnKeyDown(IntPtr hWnd, NativeKeyEventArgs keyEventArgs)
        {
            //KeyDown?.Invoke(this, keyEventArgs);
            SafeInvoke(this.KeyDown, keyEventArgs); 
        }

        protected virtual void OnKeyUp(IntPtr hWnd, NativeKeyEventArgs keyEventArgs)
        {
            SafeInvoke(this.KeyUp, keyEventArgs);
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
            //Clicked?.Invoke(this, EventArgs.Empty);
            SafeInvoke(this.Clicked, EventArgs.Empty);
        }

        protected virtual void OnDblClicked()
        {
            SafeInvoke(this.DblClicked, EventArgs.Empty);
            //DblClicked?.Invoke(this, EventArgs.Empty);
        }

        public virtual void Destroy()
        {
            Console.Write("on Destroy");
        }

        protected void SafeInvoke<T>(EventHandler<T> eventHandler, T args) where T : EventArgs
        {
            try
            {
                eventHandler?.Invoke(this, args);
            }
            catch (Exception e)
            {
                MessageBox.Show("Event Error:" + e.Message);
            }
        }

        protected   void SafeInvokeAsync<T>(EventHandler<T> eventHandler, T args) where T:EventArgs
        {
            this._TaskQueue.Enqueue(()=>Task.Run(()=> eventHandler?.Invoke(this,args)));
        }

        public bool Enabled
        {
            get => this.Control.Enabled;
            set => this.Control.Enabled = value;
        }

        string IControl.TypeIdentifyer
        {
            get => this.TypeIdentifier;
            set => this.TypeIdentifier = value;
        }

        public ControlType ControlType { get; set; }

        public ControlCollection Controls => this._Control.Controls;

        private void DoAnchor()
        {
            return;
            if (this.ParentHandle == IntPtr.Zero)
                return;

            if(User32.GetClientRect(this.ParentHandle, out var rect))
            {
                int currLeft = _DiffLeft;
                int currTop = _DiffTop;
                int currRight = _DiffRight;
                int currBottom = _DiffBottom;
                if(this.Left != _DiffLeft)
                {
                    this.Left = _DiffLeft;
                }
                if(this.Top != _DiffTop)
                {
                    this.Top = _DiffTop;
                }
                int newTop = this.Top;
                int newLeft = this.Left;
                int newWidth = rect.Width - _DiffLeft - _DiffRight;
                int newHeight = rect.Height - _DiffTop - _DiffBottom;
                this.Left = newLeft;
                this.Top = newTop;
                this.Width = newWidth;
                this.Height = newHeight;
            }

        }

        public virtual void OnParentResize()
        {
            DoAnchor();
        }
    }
}