using System;
using CoreWindowsWrapper.Api.Win32;
using CoreWindowsWrapper.Win32ApiForm;

namespace CoreWindowsWrapper
{
    public class NativeWindow:IControl
    {
        private Win32Window _Window;
        internal bool IsMainWindow { get; set; }
        public ControlCollection Controls => this._Window.Controls;

        public IntPtr Handle
        {
            get
            {
                if (this._Window != null)
                {
                    return this._Window.Handle;
                }
                return IntPtr.Zero;
            }
        }
        public event EventHandler<CreateEventArgs> Create;
        public event EventHandler<MouseClickEventArgs> DoubleClick;
        public event EventHandler<MouseClickEventArgs> Click;

        protected NativeWindow()
        {
            Initialize();
        }
        
        public void Close()
        {
             this._Window.Close();
        }

        public IntPtr ParentHandle { get; set; }

        public string Name
        {
            get => this._Window.Name;
            set => this._Window.Name = value;
        }

        public string Text
        {
            get => this._Window.Text;
            set => this._Window.Text = value;
        }

        public int BackColor
        {
            get { return this._Window.Color; }
            set { this._Window.Color = value; }
        }

        public int Left
        {
            get => this._Window.Left;
            set => this._Window.Left = value;
        }

        public int Top
        {
            get => this._Window.Top;
            set => this._Window.Top = value;
        }

        public int Width
        {
            get => this._Window.Width;
            set => this._Window.Width = value;
        }

        public int Height
        {
            get => this._Window.Height;
            set => this._Window.Height = value;
        }

        public Point Location { get; set; }
        public int ControlId { get; set; } = -1;
        bool IControl.Create(IntPtr parentId)
        {
            throw new NotImplementedException();
        }

        public bool HandleEvents(IntPtr hWndParent, IntPtr hWndControl, int controlId, uint command, IntPtr wParam, IntPtr lParam)
        {
            throw new NotImplementedException();
        }

        private void Initialize()
        {
            this._Window = new Win32Window
            {
                Style = WindowStylesConst.WS_CAPTION | WindowStylesConst.WS_SYSMENU |
                        WindowStylesConst.WS_EX_STATICEDGE
            };

            this._Window.CreateForm += OnCreateForm;
            this._Window.DoubleClick += OnFormDoubleClick;
            this._Window.Click += OnFormClick;
            InitControls();
        }

        protected virtual void InitControls()
        {
            //INitControls
        }

        public void Dispatch()
        {
            this._Window.Dispatch();
        }

        private void OnFormClick(object sender, MouseClickEventArgs e)
        {
         OnClick(e);  
        }

        private void OnFormDoubleClick(object sender, MouseClickEventArgs e)
        {
            OnDoubleClick(e);
        }

        private void OnCreateForm(object sender, CreateEventArgs e)
        {
            OnCreate(e);
        }

        public void Show()
        {
            this._Window.Create();
            
        }

        protected virtual void OnCreate(CreateEventArgs e)
        {
            Create?.Invoke(this, e);
        }

        protected virtual void OnDoubleClick(MouseClickEventArgs e)
        {
            DoubleClick?.Invoke(this, e);
        }

        protected virtual void OnClick(MouseClickEventArgs e)
        {
            Click?.Invoke(this, e);
        }
    }
}