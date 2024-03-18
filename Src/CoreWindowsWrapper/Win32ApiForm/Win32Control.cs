using System;
using System.Runtime.InteropServices;
using Diga.Core.Api.Win32;
using Diga.Core.Api.Win32.GDI;

namespace CoreWindowsWrapper.Win32ApiForm
{
    internal class Win32Control : IWindowClass
    {

        public static int LastControlId { get; set; } = 500;
        public ApiHandleRef Handle { get; protected set; } = IntPtr.Zero;
        public ApiHandleRef ParentHandle { get; internal set; } = IntPtr.Zero;
        public string Text { get; set; }
        public string Name { get; set; }
        // private  IntPtr ControlProc(IntPtr hwnd, uint msg, IntPtr wparam, IntPtr lparam)
        public WndProc WndProc { get; set; }

        private bool _Visible = true;

        public bool Visible
        {
            get => this._Visible;
            set
            {
                this._Visible = value;
                SetControlVisible(this._Visible);
            }
        }
        public Point Location
        {
            get => new Point(this.Left, this.Top); 
            set
            {
                this.Left = value.X;
                this.Top = value.Y;
            }
        }

        public Size Size
        {
            get
            {
                return new Size(this.Width, this.Height);
            }
            set
            {
                this.Width = value.cx; 
                this.Height = value.cy;
            }
        }
        private bool _Enabled = true;
        public ControlCollection Controls { get; }
        public bool Enabled
        {
            get { return this._Enabled; }
            set
            {
                this._Enabled = value;
                if (this.Handle.IsValid)
                {
                    User32.EnableWindow(this.Handle, this._Enabled);
                }
            }
        }

        public int Left
        {
            get { return this._Left; }
            set
            {
                this._Left = value;
                MoveControlWindow();
            }
        }

        public int Top
        {
            get { return this._Top; }
            set
            {
                this._Top = value;
                MoveControlWindow();
            }
        }

        public int Width
        {
            get { return this._Width; }
            set
            {
                this._Width = value;
                MoveControlWindow();
            }
        }

        public int Height
        {
            get { return this._Height; }
            set
            {
                this._Height = value;
                MoveControlWindow();
            }
        }

        public bool ClientEdge { get; set; }
        public string TypeIdentifyer { get; set; }
        public int ControlId { get; set; }
        public int BackColor { get; set; } = 0xF0F0F0;
        public int ForeColor { get; set; }
        public Font Font { get; set; }
        public CommonControls CommonControlType { get; set; } = CommonControls.ICC_UNDEFINED;

        public uint Style { get; set; } =
            WindowStylesConst.WS_VISIBLE | WindowStylesConst.WS_CHILD | WindowStylesConst.WS_TABSTOP;

        private readonly WndProc _DelegateWndProc;
        private IntPtr _OldDelgateWndProc = IntPtr.Zero;
        private int _Left;
        private int _Top;
        private int _Width;
        private int _Height;

        public Win32Control()
        {
            this._DelegateWndProc = ControlProc;
            this.Controls = new ControlCollection(this);
        }
        public Win32Control(WndProc delegateWndProc)
        {
            this._DelegateWndProc = delegateWndProc;
            this.Controls = new ControlCollection(this);
        }
        internal  void SetNewPos(Rect rect)
        {
            uint flags = (uint)SetWindowPosFlags.DoNotActivate | (uint)SetWindowPosFlags.DoNotSendChangingEvent | (uint)SetWindowPosFlags.IgnoreZOrder;
            if (User32.SetWindowPos(this.Handle, IntPtr.Zero, rect.X, rect.Y, rect.Width, rect.Height, flags))
            {
                this._Width = rect.Width;
                this._Height = rect.Height;
                this._Left = rect.Left;
                this._Top = rect.Top;
            }

        }
        private void MoveControlWindow()
        {
            if (!this.Handle.IsValid) return;
            User32.MoveWindow(this.Handle, this.Left, this.Top, this.Width, this.Height, true);
        }

        private void SetControlVisible(bool visible)
        {
            if(!this.Handle.IsValid) return;
            ShowWindowCommands cmd = ShowWindowCommands.Hide;
            if (visible)
                cmd = ShowWindowCommands.Show;
            User32.ShowWindow(this.Handle, (int)cmd);
        }

        private  IntPtr ControlProc(IntPtr hwnd, uint msg, IntPtr wparam, IntPtr lparam)
        {
            if(_OldDelgateWndProc !=IntPtr.Zero)
            {
                if(this.WndProc != null)
                {
                    IntPtr result = this.WndProc(hwnd , msg, wparam , lparam);
                    if(result != IntPtr.Zero)
                    {
                        return result;
                    }
                }
                return User32.CallWindowProc(_OldDelgateWndProc, hwnd, (int)msg, wparam, lparam);
            }
            else
            {
                return User32.DefWindowProc(hwnd, msg, wparam, lparam);
            }
            
        }

        public void PreCreate(IntPtr hWnd)
        {
            if (Win32Window.WindowList.ContainsKey(hWnd))
            {
                var window = Win32Window.WindowList[hWnd];
                foreach (var control in this.Controls.Values)
                {
                    window.Controls.Add(control);
                }

                this.Controls.Clear();

            }

        }

        internal virtual bool CreateChilds() 
        {
            bool result = true;
            foreach (var control in this.Controls.Values)
            {
                result &= control.Create(this.Handle);
            }
            return result;
        }
        internal virtual bool Create(IntPtr parentHandle)
        {

            //if(this.ControlId == 0)
            //{
            //    LastControlId += 1;
            //    this.ControlId = LastControlId;
            //}
            if (this.CommonControlType != CommonControls.ICC_UNDEFINED)
            {
                InitCommonControlsEx ccInit = new InitCommonControlsEx(this.CommonControlType);
                ComCtl32.InitCommonControlsEx(ref ccInit);
            }

            this.ParentHandle = parentHandle;



            int edged = 0;
            if (this.ClientEdge)
                edged = (int)WindowStyles.WS_EX_CLIENTEDGE;

            this.Handle = User32.CreateWindowEx(
                edged,
                this.TypeIdentifyer,
                this.Text,
                this.Style,
                this.Left,
                this.Top,
                this.Width,
                this.Height,
                this.ParentHandle,
                (IntPtr)this.ControlId,
                IntPtr.Zero,
                IntPtr.Zero);

            if (this.Font != null)
            {
                this.Font.FromLogFont(this.Handle);

                LogFont f = this.Font.ToLogFont(this.Handle);
                IntPtr hFont = Gdi32.CreateFontIndirect(ref f);
                IntPtr retVal = User32.SendMessage(this.Handle, WindowsMessages.WM_SETFONT, hFont, 0);
            }

            _OldDelgateWndProc =  User32.SetWindowLongPtr(this.Handle, GWL.GWL_WNDPROC, Marshal.GetFunctionPointerForDelegate((WndProc)_DelegateWndProc));

            // CreateChilds();

            return true;
        }

        public void UpdateStyle(uint style)
        {
            IntPtr p = new IntPtr(style);
            //this.Style = style;
            User32.SetWindowLongPtr(this.Handle, GWL.GWL_STYLE, p);

        }
        public void UpdateExStyle(uint exStyle)
        {
            IntPtr p = new IntPtr(exStyle);
            //this.StyleEx = exStyle;
            User32.SetWindowLongPtr(this.Handle, GWL.GWL_EXSTYLE, p);

        }

        public uint GetStyle()
        {
            IntPtr style = User32.GetWindowLongPtr(this.Handle, GWL.GWL_STYLE);
            uint s = unchecked((uint)style.ToInt64());
            return s;
        }

        public uint GetExStyle()
        {
            IntPtr exStyle = User32.GetWindowLongPtr(this.Handle, GWL.GWL_EXSTYLE);
            uint s = unchecked((uint)exStyle.ToInt64());
            return s;
        }

        public void Destroy()
        {
            if(this.Handle.IsValid)
            {
                User32.DestroyWindow(this.Handle);
                this.Handle = IntPtr.Zero;

            }
        }
        public WndclassEx WindowClass { get; set; }
    }
}