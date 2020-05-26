using System;
using System.Threading.Tasks;
using CoreWindowsWrapper.Api.Win32;
using CoreWindowsWrapper.Win32ApiForm;

namespace CoreWindowsWrapper
{

    public class NativeControlBase : IControl
    {
        private Win32Control _Control;
        internal virtual Win32Control Control { get => this._Control; set => this._Control = value; }
        public virtual event EventHandler<EventArgs> Clicked;
        public virtual event EventHandler<EventArgs> DblClicked;
        private Font _Font;
        private TaskQueue _TaskQueue = new TaskQueue();

        public NativeControlBase()
        {
            this.Font = new Font();
            this.ControlType = ControlType.DefaultControl;
            Initialize();
        }


        protected virtual void Initialize()
        {
            this.Control = new Win32Control();
            this.Control.Font = this._Font;
            this.Control.BackColor = 0xF0F0F0;

        }

        protected virtual void AfterCreate()
        {

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



        public virtual bool Create(IntPtr parentId)
        {
            bool retCreate = this.Control.Create(parentId);
            this.AfterCreate();
            return retCreate;
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

    }
}