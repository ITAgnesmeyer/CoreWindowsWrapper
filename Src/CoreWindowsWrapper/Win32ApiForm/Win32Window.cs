using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CoreWindowsWrapper.Api.Win32;
using Point = CoreWindowsWrapper.Api.Win32.Point;

namespace CoreWindowsWrapper.Win32ApiForm
{
    internal sealed class Win32Window : IWindowClass,IDisposable
    {
        public bool IsMainWindow { get; set; }

        public event EventHandler<CreateEventArgs> CreateForm;
        public event EventHandler<MouseClickEventArgs> DoubleClick;
        public event EventHandler<MouseClickEventArgs> Click;
        public event EventHandler<MouseClickEventArgs> MouseDown;
        public event EventHandler<MouseClickEventArgs> MouseUp;
        public event EventHandler<CreateEventArgs> Destroyed;
        public event EventHandler<SizeEventArgs> Size;
        
        private static readonly Dictionary<IntPtr, Win32Window> WindowList = new Dictionary<IntPtr, Win32Window>();
        private static readonly Stack<Win32Window> WindowStack = new Stack<Win32Window>();
        public static IntPtr InstanceHandle { get; set; } = IntPtr.Zero;
        public ControlCollection Controls;
        public MenuItemCollection FlatMenuItems;
        public IntPtr Handle { get; private set; }
        public IntPtr ParentHandle { get; set; }
        public int Color { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        internal string WindowClassName { get; set; }
        internal IntPtr StatusBarHandle { get; set; } = IntPtr.Zero;
        public Point Location
        {
            get => new Point(){X=this.Left, Y=this.Top};
            set
            {
                this.Left = value.X;
                this.Top = value.Y;
            }
        }

        public int Left
        {
            get => this._Left;
            set
            {
                this._Left = value;
                MoveMyWindow();
            }
        }

        public int Top
        {
            get => this._Top;
            set
            {
                this._Top = value;
                MoveMyWindow();
            }
        }

        public int Width
        {
            get => this._Width;
            set
            {
                this._Width = value;
                MoveMyWindow();
            }
        }

        public int Height
        {
            get => this._Height;
            set
            {
                this._Height = value;
                MoveMyWindow();
            }
        }

        public string IconFile { get; set; }
        public bool CenterForm { get; set; }
        public bool MaximizeForm { get; set; }
        public bool MinimizeForm { get; set; }
        public bool Statusbar{get;set;} = false;
        public bool Enable
        {
            get => Win32Api.IsWindowEnabled(this.Handle);
            set => Win32Api.EnableWindow(this.Handle, value);
        }
        private static IntPtr _lastMessageReturn = IntPtr.Zero;
        private readonly WndProc _DelegateWndProc = MyWndProc;
        private int _Left = unchecked((int) 0x80000000);
        private int _Top = unchecked((int) 0x80000000);
        private int _Width = unchecked((int) 0x80000000);
        private int _Height= unchecked((int) 0x80000000);
        public IMenuItem Menu{get;set;}
        private Point _Location;
        public uint Style { get; set; } = WindowStylesConst.WS_OVERLAPPEDWINDOW | WindowStylesConst.WS_VISIBLE;

        public Win32Window(bool isMainWindow = false)
        {
            this.Controls = new ControlCollection(this);
            this.FlatMenuItems = new MenuItemCollection();
            this.IsMainWindow = isMainWindow;
            this.Name = "Win32WindowClass";
            this.Text = this.Name;
            this.Color = 0xF0F0F0;
        }

        public Win32Window(IntPtr parentHandle,bool isMainWindow = false)
        {
            this.Controls = new ControlCollection(this);
            this.FlatMenuItems = new MenuItemCollection();
            this.IsMainWindow = isMainWindow;
            this.ParentHandle = parentHandle;
            this.Name = "Win32WindowClass";
            this.Text = this.Name;
            this.Color = 0xF0F0F0;
        }

        private void MoveMyWindow()
        {
            if (this.Handle == IntPtr.Zero) return;
            Win32Api.MoveWindow(this.Handle, this.Left, this.Top, this.Width, this.Height, true);
        }

        internal void Close()
        {
            Win32Api.SendMessage(this.Handle, WindowsMessages.WM_CLOSE);
        }

        internal bool Create(bool asControl = false)
        {
            this.WindowClassName = this.Name + "_" + WindowList.Count;
            Wndclassex windClass = new Wndclassex
            {
                cbSize = Marshal.SizeOf(typeof(Wndclassex)),
                style = (int) (ClassStyles.CS_HREDRAW | ClassStyles.CS_VREDRAW | ClassStyles.CS_DBLCLKS),
                hbrBackground = Win32Api.GetStockObject(StockObjects.WHITE_BRUSH),
                cbClsExtra = 0,
                cbWndExtra = 0,
                hInstance = Process.GetCurrentProcess().Handle,
                hIcon = Tools.ImageTool.SaveLoadIconFromFile(this.IconFile),
                hCursor = Win32Api.LoadCursor(IntPtr.Zero, (int) Win32ApiCursors.IDC_ARROW),
                lpszMenuName = null,
                lpszClassName = this.WindowClassName,
                lpfnWndProc = Marshal.GetFunctionPointerForDelegate(this._DelegateWndProc),
                hIconSm = IntPtr.Zero
            };
            //Doubleclicks are active
            //Black background, +1 is necessary
            // alternative: Process.GetCurrentProcess().Handle;
            // Crosshair cursor;
            IntPtr hMenu = IntPtr.Zero;

            Win32Window.InstanceHandle = windClass.hInstance;

            if (this.Menu != null)
            {
                this.Menu.Create(hMenu);
                hMenu = this.Menu.ParentMenuHandle;
                
                FillFlatMenuItemList(this.Menu);

            }


            windClass.hbrBackground = Win32Api.CreateSolidBrush(this.Color);
            this.WindowClass = windClass;
            ushort regResult = Win32Api.RegisterClassEx(ref windClass);

            if (regResult == 0)
            {
                // ReSharper disable once UnusedVariable
                uint error = Win32Api.GetLastError();
                return false;
            }

            
            WindowStack.Push(this);
            //The next line did NOT work with me! When searching the web, the reason seems to be unclear! 
            //It resulted in a zero hWnd, but GetLastError resulted in zero (i.e. no error) as well !!??)
            //IntPtr hWnd = CreateWindowEx(0, wind_class.lpszClassName, "MyWnd", WS_OVERLAPPEDWINDOW | WS_VISIBLE, 0, 0, 30, 40, IntPtr.Zero, IntPtr.Zero, wind_class.hInstance, IntPtr.Zero);

            //This version worked and resulted in a non-zero hWnd
            //Rect rect;
            //Win32Api.GetWindowRect(hWnd, out rect);
            if (this.CenterForm)
            {
                int xPos = (Win32Api.GetSystemMetrics(SystemMetric.SM_CXSCREEN) - this.Width) / 2;
                int yPos = (Win32Api.GetSystemMetrics(SystemMetric.SM_CYSCREEN) - this.Height) / 2;
                this.Left = xPos;
                this.Top = yPos;
            }

            IntPtr hWnd = Win32Api.CreateWindowEx((int) (WindowStylesConst.WS_EX_APPWINDOW | WindowStylesConst.WS_EX_CLIENTEDGE),
                this.WindowClassName,
                this.Text, this.Style
                , this.Left, this.Top, this.Width, this.Height,this.ParentHandle, hMenu
                , windClass.hInstance, IntPtr.Zero);



            this.Handle = hWnd;
            if (hWnd == ((IntPtr) 0))
            {
                // ReSharper disable once UnusedVariable
                uint error = Win32Api.GetLastError();
                return false;
            }

            if (asControl)
            {
                if (this.ParentHandle != IntPtr.Zero)
                    Win32Api.SetParent(this.Handle, this.ParentHandle);

            }

            if (WindowList.ContainsKey(this.Handle))
                WindowList.Remove(this.Handle);

            WindowList.Add(this.Handle, this);
            int cmdShow = (int) ShowWindowCommands.ShowDefault;
            if (this.MaximizeForm)
                cmdShow = (int) (ShowWindowCommands.Maximize);
            if (this.MinimizeForm)
                cmdShow = (int) (ShowWindowCommands.Minimize);
            Win32Api.ShowWindowAsync(hWnd, cmdShow);


            Win32Api.UpdateWindow(hWnd);
            

            OnCreate();

            //Win32Api.SetWindowPos(this.Handle, (IntPtr) 0,xPos,yPos,0,0,(uint)(SetWindowPosFlags.IgnoreResize | SetWindowPosFlags.IgnoreZOrder));
            if (!this.IsMainWindow)
            {
                //The explicit message pump is not necessary, messages are obviously dispatched by the framework.
                //However, if the while loop is implemented, the functions are called... Windows mysteries...
                while (Win32Api.GetMessage(out var msg, IntPtr.Zero, 0, 0) != 0)
                {
                    Win32Api.TranslateMessage(ref msg);
                    Win32Api.DispatchMessage(ref msg);
                    if(WindowList.Count == 0) break;
                    
                }
            }

            return true;
        }

        private void FillFlatMenuItemList(IMenuItem menu)
        {
            if (menu is NativeMenu)
            {
                NativeMenu men = menu as NativeMenu;
                foreach (var menuItem in men.Items.Values)
                {
                    FillFlatMenuItemList(menuItem);
                }
            }
            else
            {
                NativeMenuItem men = menu as NativeMenuItem;
                this.FlatMenuItems.Add(men);
                if (men != null)
                    foreach (var menuItem in men.Items.Values)
                    {
                        FillFlatMenuItemList(menuItem);
                    }
            }
        }

        public void Dispatch()
        {
            if (Win32Api.GetMessage(out var msg, IntPtr.Zero, 0, 0) != 0)
            {
                Win32Api.TranslateMessage(ref msg);
                Win32Api.DispatchMessage(ref msg);
            }
        }

        private static IntPtr MyWndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
        {
            switch (msg)
            {
                case WindowsMessages.WM_CLOSE:
                    InvokeEvent(msg, hWnd, wParam, lParam);
                    SetWindowDestroyed(hWnd);


                    break;


                case WindowsMessages.WM_DESTROY:

                    //If you want to shutdown the application, call the next function instead of DestroyWindow

                    Win32Api.PostQuitMessage(0);
                    break;

                default:
                    if (!InvokeEvent(msg, hWnd, wParam, lParam))
                        return Win32Api.DefWindowProc(hWnd, msg, wParam, lParam);
                    else if (_lastMessageReturn != IntPtr.Zero)
                        return _lastMessageReturn;
                    else
                        break;
            }

            return IntPtr.Zero;
        }

        private void Destroy()
        {
            OnDestroy(new CreateEventArgs(this.Handle));
            foreach (var item in this.Controls)
            {
                item.Value.Destroy();
            }

            Win32Api.DestroyWindow(this.Handle);
            if (Win32Api.UnregisterClass(this.WindowClassName, Process.GetCurrentProcess().Handle))
                Debug.WriteLine("Windows unreigistered!:" + this.WindowClassName);
            else
                Debug.WriteLine("Window not unregistred!:" + this.WindowClassName);
            this.Handle = IntPtr.Zero;
        }

        private static void SetWindowDestroyed(IntPtr hWnd)
        {
            if (WindowList.ContainsKey(hWnd))
            {
                Win32Window win32Window = WindowList[hWnd];
                bool isMainWindow = win32Window.IsMainWindow;

                if (isMainWindow)
                {
                    foreach (var window in WindowList.Values)
                    {
                        
                        IntPtr childHand = window.Handle;
                        if (childHand != hWnd)
                        {
                            window.Destroy();
                            WindowList.Remove(childHand);
                        }
                    }
                }

                win32Window.Destroy();
                WindowList.Remove(hWnd);

            
        }
        }

        private static bool InvokeEvent(uint eventType, IntPtr hWnd, IntPtr wParam, IntPtr lParam)
        {
            bool handled = true;
            _lastMessageReturn = IntPtr.Zero;
            Win32Window window;
            if (eventType == WindowsMessages.WM_CREATE)
            {
                window = WindowStack.Pop();
                window.Handle = hWnd;
            }
            else
            {
                if (!WindowList.ContainsKey(hWnd)) return false;
                window = WindowList[hWnd];
            }

           
            switch (eventType)
            {
                case WindowsMessages.WM_NOTIFY:
                    NMHDR hdr = null;
                    try
                    {
                        object obj = Marshal.PtrToStructure(lParam,typeof(NMHDR));
                        hdr = (NMHDR)obj;
                    }
                    catch (Exception e)
                    {
                        Debug.Print(e.Message);


                    }

                    uint test = unchecked((0U - 0U) - 2);
                    if (hdr != null && hdr.code == test)
                    {
                        int cId = Convert.ToInt32(hdr.idFrom);
                        uint cCmd = hdr.code;
                        IntPtr hCWndControl = hdr.hwndFrom;
                        if (window.Controls.ContainsKey(cId))
                        {
                            IControl cControl = window.Controls[cId];
                            handled = cControl.HandleEvents(hWnd, hCWndControl, cId, cCmd, wParam, lParam);
                        }
                    }
                    break;
                case WindowsMessages.WM_COMMAND:
                    int controlId = Win32Api.LoWord(wParam.ToInt32());
                    uint command = (uint) Win32Api.HiWord(wParam.ToInt32());
                    IntPtr hWndControl = lParam;
                    if (window.Controls.ContainsKey(controlId))
                    {
                        IControl control = window.Controls[controlId];
                        handled = control.HandleEvents(hWnd, hWndControl, controlId, command, wParam, lParam);
                    }
                    else
                    {
                        if (window.FlatMenuItems.ContainsKey(controlId))
                        {
                            IMenuItem menu = window.FlatMenuItems[controlId];
                            handled = menu.HandleEvents(hWnd, hWndControl, controlId, command, wParam, lParam);
                        }
                        else
                        {
                            handled = false;
                        }
                        
                    }


                    break;
                case WindowsMessages.WM_CREATE:

                    if (window.Statusbar)
                    {
                       
                        IntPtr sbId = new IntPtr(100);
                        window.StatusBarHandle = Win32Api.CreateWindowEx(0, "msctls_statusbar32", null,
                            (uint)(WindowStyles.WS_VISIBLE | WindowStyles.WS_CHILD), 0, 0, 0, 0, hWnd, sbId,
                            Win32Window.InstanceHandle, IntPtr.Zero);
                        Win32Api.ShowWindow(window.StatusBarHandle, (int)ShowWindowCommands.Show);
                    }

                    foreach (IControl windowControl in window.Controls.Values)
                    {
                        windowControl.Create(hWnd);
                    }


                    _lastMessageReturn = new IntPtr(1);
                    break;


                case WindowsMessages.WM_PAINT:
                    Paintstruct ps;
                    // ReSharper disable once UnusedVariable
                    IntPtr hdc = Win32Api.BeginPaint(hWnd, out ps);
                    window.OnPaint(hWnd, ps);
                    Win32Api.EndPaint(hWnd, ref ps);
                    break;
                case WindowsMessages.WM_LBUTTONDBLCLK:
                    window.OnDoubleClick(new MouseClickEventArgs(MouseButton.Left, hWnd));

                    break;
                case WindowsMessages.WM_LBUTTONDOWN:
                    window.OnClick(new MouseClickEventArgs(MouseButton.Left, hWnd));
                    window.OnMouseDown(new MouseClickEventArgs(MouseButton.Left, hWnd));
                    break;
                case WindowsMessages.WM_LBUTTONUP:
                    window.OnMouseUp(new MouseClickEventArgs(MouseButton.Left, hWnd));
                    break;

                case WindowsMessages.WM_RBUTTONDBLCLK:
                    window.OnDoubleClick(new MouseClickEventArgs(MouseButton.Right, hWnd));
                    break;
                case WindowsMessages.WM_RBUTTONDOWN:
                    window.OnClick(new MouseClickEventArgs(MouseButton.Right, hWnd));
                    window.OnMouseDown(new MouseClickEventArgs(MouseButton.Right, hWnd));
                    break;
                case WindowsMessages.WM_RBUTTONUP:
                    window.OnMouseUp(new MouseClickEventArgs(MouseButton.Right, hWnd));
                    break;
                case WindowsMessages.WM_MBUTTONDBLCLK:
                    window.OnDoubleClick(new MouseClickEventArgs(MouseButton.Middle, hWnd));
                    break;
                case WindowsMessages.WM_MBUTTONDOWN:
                    window.OnMouseDown(new MouseClickEventArgs(MouseButton.Middle, hWnd));
                    break;
                case WindowsMessages.WM_MBUTTONUP:
                    window.OnMouseUp(new MouseClickEventArgs(MouseButton.Middle, hWnd));
                    break;
                case WindowsMessages.WM_HANDHELDFIRST:
                    window.OnCreate();
                    break;

                case WindowsMessages.WM_CTLCOLOREDIT :
                    CtlColors(wParam, lParam, window);
                    break;
                case WindowsMessages.WM_CTLCOLORSTATIC:
                    CtlColors(wParam, lParam, window);
                    break;

                case WindowsMessages.WM_CTLCOLORBTN:
                    CtlColors(wParam,lParam,window);
                    break;

                case WindowsMessages.WM_CTLCOLORLISTBOX:
                    
                    CtlColors(wParam,lParam,window);
                    break;
                
                case WindowsMessages.WM_SIZE:
                    if (window.Statusbar)
                    {
                        Win32Api.SendMessage(window.StatusBarHandle, WindowsMessages.WM_SIZE, 0, 0);
                    }
                        
                    Rect r = window.GetCleanClientRect();
                    window.OnSize(new SizeEventArgs(r.X, r.Y,  r.Right - r.Left , r.Bottom - r.Top));
                    //handled = false;
                    break;
                case WindowsMessages.WM_SIZING:
                    Rect rz = window.GetCleanClientRect();
                    window.OnSize(new SizeEventArgs(rz.X, rz.Y,  rz.Right - rz.Left , rz.Bottom - rz.Top));
                    break;

                case WindowsMessages.WM_MOVE:
                    Rect rzs = window.GetCleanClientRect();
                    window.OnSize(new SizeEventArgs(rzs.X, rzs.Y,  rzs.Right - rzs.Left , rzs.Bottom - rzs.Top));
                    break;

                default:
                    handled = false;
                    break;
            }

            return handled;
        }

        private static void CtlColors(IntPtr wParam, IntPtr lParam, Win32Window window)
        {
            IntPtr editCtlHdc = wParam;
            int editControlId = Win32Api.GetDlgCtrlID(lParam);
            _lastMessageReturn = Win32Api.CreateSolidBrush(Tools.ColorTool.White);
            if (window.Controls.ContainsKey(editControlId))
            {
                IControl control = window.Controls[editControlId];

                if (control.ControlType == ControlType.ComboBox)
                {
                    COMBOBOXINFO cinfo = new COMBOBOXINFO();
                    cinfo.cbSize = (uint)Marshal.SizeOf<COMBOBOXINFO>();
                    if (Win32Api.GetComboBoxInfo(control.Handle, ref cinfo))
                    {
                        Win32Api.SetBkColor(cinfo.hwndCombo, control.BackColor);
                        Win32Api.SetTextColor(cinfo.hwndCombo, control.ForeColor);
                        Win32Api.SetBkColor(cinfo.hwndItem, control.BackColor);
                        Win32Api.SetTextColor(cinfo.hwndItem, control.ForeColor);
                        Win32Api.SetBkColor(cinfo.hwndList, control.BackColor);
                        Win32Api.SetTextColor(cinfo.hwndList, control.ForeColor);
                    }
                }
                else
                {
                    Win32Api.SetTextColor(editCtlHdc, control.ForeColor);
                    Win32Api.SetBkColor(editCtlHdc, control.BackColor);
                }

                IntPtr brush = Win32Api.CreateSolidBrush(control.BackColor);
                _lastMessageReturn = brush;
               
            }
        }

        private void OnPaint(IntPtr hWnd, Paintstruct ps)
        {
            
        }

        private void OnCreate()
        {
            CreateForm?.Invoke(this, new CreateEventArgs(this.Handle));
        }

        private void OnDoubleClick(MouseClickEventArgs e)
        {
            DoubleClick?.Invoke(this, e);
        }


        private void OnClick(MouseClickEventArgs e)
        {
            Click?.Invoke(this, e);
        }

        private void OnMouseDown(MouseClickEventArgs e)
        {
            MouseDown?.Invoke(this, e);
        }

        private void OnMouseUp(MouseClickEventArgs e)
        {
            MouseUp?.Invoke(this, e);
        }

        private void OnDestroy(CreateEventArgs e)
        {
            Destroyed?.Invoke(this,e);
        }

        public Wndclassex WindowClass { get; set; }

        public void Dispose()
        {
            this.Controls?.Dispose();
            this.Controls = null;
        }

        public void AttachToWindow(IntPtr parent)
        {
            this.ParentHandle = parent;
            Win32Api.SetParent(this.Handle, this.ParentHandle);
        }

        private void OnSize(SizeEventArgs e)
        {
            Size?.Invoke(this, e);
        }

        public Rect GetCleanClientRect()
        {
            int sbHeigt = 0;
            if (this.Statusbar)
            {
                
                Win32Api.GetWindowRect(this.StatusBarHandle, out var sbRect);
                sbHeigt = sbRect.Bottom - sbRect.Top;
            }
                        
            Win32Api.GetClientRect(this.Handle, out var r);
            r.Bottom = r.Bottom - sbHeigt;
            return r;
        }
    }
}