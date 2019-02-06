using System;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper.Win32ApiForm
{
    internal class Win32Control : IWindowClass
    {
        
        public static int LastControlId{get;set;} = 500;
        public IntPtr Handle { get; protected set; }
        public IntPtr ParentHandle { get; internal set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public Point Location { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string TypeIdentifyer { get; set; }
        public int ControlId { get; set; }
        public int BackColor { get; set; }
        public int ForeColor{get;set;}
        public Font Font{get;set;}
        public CommonControls CommonControType { get; set; } = CommonControls.ICC_UNDEFINED;
        public uint Style { get; set; } =
            (WindowStylesConst.WS_VISIBLE | WindowStylesConst.WS_CHILD | WindowStylesConst.WS_TABSTOP);

        private readonly WndProc _DelegateWndProc = MyWndProc;

        private static IntPtr MyWndProc(IntPtr hwnd, uint msg, IntPtr wparam, IntPtr lparam)
        {
            return Win32Api.DefWindowProc(hwnd, msg, wparam, lparam);
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
            this.Handle  = Win32Api.CreateWindowEx(0,
                this.TypeIdentifyer , this.Text,
                this.Style, this.Left ,
                this.Top,
                this.Width, this.Height, this.ParentHandle,
                (IntPtr) this.ControlId, IntPtr.Zero, IntPtr.Zero);

            if(this.Font != null)
            {

                this.Font.FromLogFont(this.Handle);

                LOGFONTW f =  this.Font.ToLogFont(this.Handle);
                IntPtr hFont = Win32Api.CreateFontIndirect(ref f);
               IntPtr retVal = Win32Api.SendMessage(this.Handle,WindowsMessages.WM_SETFONT,hFont,0);

            }
     
            return true;

        }

        public Wndclassex WindowClass { get; set; }
    }
}