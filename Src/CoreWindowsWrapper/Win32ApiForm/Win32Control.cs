using System;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper.Win32ApiForm
{
    internal class Win32Control : IWindowClass
    {

        public static int LastControlId { get; set; } = 500;
        public IntPtr Handle { get; protected set; }
        public IntPtr ParentHandle { get; internal set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public Point Location { get; set; }
        private bool _Enabled = true;
        public ControlCollection Controls { get; }
        public bool Enabled
        {
            get { return this._Enabled; }
            set
            {
                this._Enabled = value;
                if (this.Handle != IntPtr.Zero)
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

        private void MoveControlWindow()
        {
            if (this.Handle == IntPtr.Zero) return;
            User32.MoveWindow(this.Handle, this.Left, this.Top, this.Width, this.Height, true);
        }

        private static IntPtr ControlProc(IntPtr hwnd, uint msg, IntPtr wparam, IntPtr lparam)
        {

            return User32.DefWindowProc(hwnd, msg, wparam, lparam);
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
                (IntPtr) this.ControlId,
                IntPtr.Zero,
                IntPtr.Zero);

            if (this.Font != null)
            {
                this.Font.FromLogFont(this.Handle);

                LogFont f = this.Font.ToLogFont(this.Handle);
                IntPtr hFont = Gdi32.CreateFontIndirect(ref f);
                IntPtr retVal = User32.SendMessage(this.Handle, WindowsMessages.WM_SETFONT, hFont, 0);
            }



            return true;
        }

        public WndclassEx WindowClass { get; set; }
    }
}