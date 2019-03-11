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
        public ControlCollection Controls;
        public bool Enabled
        {
            get { return this._Enabled; }
            set
            {
                this._Enabled = value;
                if (this.Handle != IntPtr.Zero)
                {
                    Win32Api.EnableWindow(this.Handle, this._Enabled);
                }
            }
        }

        public int Left
        {
            get { return this._Left; }
            set
            {
                this._Left = value;
                MoveMyWindow();
            }
        }

        public int Top
        {
            get { return this._Top; }
            set
            {
                this._Top = value;
                MoveMyWindow();
            }
        }

        public int Width
        {
            get { return this._Width; }
            set
            {
                this._Width = value;
                MoveMyWindow();
            }
        }

        public int Height
        {
            get { return this._Height; }
            set
            {
                this._Height = value;
                MoveMyWindow();
            }
        }

        public bool ClientEdge { get; set; }
        public string TypeIdentifyer { get; set; }
        public int ControlId { get; set; }
        public int BackColor { get; set; }=0xF0F0F0;
        public int ForeColor { get; set; }
        public Font Font { get; set; }
        public CommonControls CommonControType { get; set; } = CommonControls.ICC_UNDEFINED;

        public uint Style { get; set; } =
            (WindowStylesConst.WS_VISIBLE | WindowStylesConst.WS_CHILD | WindowStylesConst.WS_TABSTOP);

        private readonly WndProc _DelegateWndProc = MyWndProc;
        private int _Left;
        private int _Top;
        private int _Width;
        private int _Height;

        public Win32Control()
        {
            this.Controls = new ControlCollection(this);
        }

        private void MoveMyWindow()
        {
            if (this.Handle == IntPtr.Zero) return;
            Win32Api.MoveWindow(this.Handle, this.Left, this.Top, this.Width, this.Height, true);
        }

        private static IntPtr MyWndProc(IntPtr hwnd, uint msg, IntPtr wparam, IntPtr lparam)
        {
           
            return Win32Api.DefWindowProc(hwnd, msg, wparam, lparam);
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
            if (this.CommonControType != CommonControls.ICC_UNDEFINED)
            {
                INITCOMMONCONTROLSEX ccInit = new INITCOMMONCONTROLSEX(this.CommonControType);
                Win32Api.InitCommonControlsEx(ref ccInit);
            }

            this.ParentHandle = parentHandle;

            

            int edged = 0;
            if (this.ClientEdge)
                edged = (int) WindowStyles.WS_EX_CLIENTEDGE;

            this.Handle = Win32Api.CreateWindowEx(edged,
                this.TypeIdentifyer, this.Text,
                this.Style, this.Left,
                this.Top,
                this.Width, this.Height, this.ParentHandle,
                (IntPtr) this.ControlId, IntPtr.Zero, IntPtr.Zero);

            if (this.Font != null)
            {
                this.Font.FromLogFont(this.Handle);

                LOGFONTW f = this.Font.ToLogFont(this.Handle);
                IntPtr hFont = Win32Api.CreateFontIndirect(ref f);
                IntPtr retVal = Win32Api.SendMessage(this.Handle, WindowsMessages.WM_SETFONT, hFont, 0);
            }

           

            return true;
        }

        public Wndclassex WindowClass { get; set; }
    }
}