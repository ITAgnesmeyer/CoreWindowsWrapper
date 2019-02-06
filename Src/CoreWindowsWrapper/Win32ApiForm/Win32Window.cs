using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CoreWindowsWrapper.Api.Win32;
using Point = CoreWindowsWrapper.Api.Win32.Point;

namespace CoreWindowsWrapper.Win32ApiForm
{
    internal sealed class Win32Window : IWindowClass
    {
        internal bool IsMainWindow { get; set; }
        
        public event EventHandler<CreateEventArgs> CreateForm;
        public event EventHandler<MouseClickEventArgs> DoubleClick;
        public event EventHandler<MouseClickEventArgs> Click;
        public event EventHandler<MouseClickEventArgs> MouseDown;
        public event EventHandler<MouseClickEventArgs> MouseUp;

        private static readonly Dictionary<IntPtr, Win32Window> WindowList = new Dictionary<IntPtr, Win32Window>();
        private static readonly Stack<Win32Window> WindowStack = new Stack<Win32Window>();
        public ControlCollection Controls = new ControlCollection();
        public IntPtr Handle { get; private set; }
        public int Color { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public Point Location { get; set; }
        public int Left { get; set; } = unchecked((int)0x80000000);
        public int Top { get; set; } = unchecked((int)0x80000000);
        public int Width { get; set; }
        public int Height { get; set; }
        public string IconFile{get;set;}
        public bool CenterForm{get;set;}= false;
        public bool MaximizeForm{get;set;} = false;
        public bool MinimizeForm{get;set;} = false;
        private static IntPtr _lastMessageReturn = IntPtr.Zero;
        private readonly WndProc _DelegateWndProc = MyWndProc;
        public uint Style{get;set;} = WindowStylesConst.WS_OVERLAPPEDWINDOW | WindowStylesConst.WS_VISIBLE;
        public Win32Window()
        {
            this.Name = "Win32WindowClass";
            this.Text = this.Name;
            this.Color = Win32Api.RGB(238,238,238);
           
        }


        internal void Close()
        {
            Win32Api.SendMessage(this.Handle,WindowsMessages.WM_CLOSE);
        }
        internal bool Create()
        {
           
            Wndclassex windClass = new Wndclassex
            {
                cbSize = Marshal.SizeOf(typeof(Wndclassex)),
                style =(int)(ClassStyles.CS_HREDRAW | ClassStyles.CS_VREDRAW | ClassStyles.CS_DBLCLKS ),
                hbrBackground = Win32Api.GetStockObject(StockObjects.WHITE_BRUSH),
                cbClsExtra = 0,
                cbWndExtra = 0,
                hInstance = Process.GetCurrentProcess().Handle
            };
            //Doubleclicks are active
            //Black background, +1 is necessary
            // alternative: Process.GetCurrentProcess().Handle;
            windClass.hIcon = Tools.ImageTool.SaveLoadIconFromFile(this.IconFile);
            windClass.hCursor = Win32Api.LoadCursor(IntPtr.Zero, (int) Win32ApiCursors.IDC_ARROW); // Crosshair cursor;
            windClass.lpszMenuName = null;
            windClass.lpszClassName = this.Name;
            windClass.lpfnWndProc = Marshal.GetFunctionPointerForDelegate(this._DelegateWndProc);
            windClass.hIconSm = IntPtr.Zero;
            windClass.hbrBackground = Win32Api.CreateSolidBrush(this.Color);
            this.WindowClass = windClass;
            ushort regResult = Win32Api.RegisterClassEx(ref windClass);

            if (regResult == 0)
            {
                uint error = Win32Api.GetLastError();
                return false;
            }

            string wndClass = windClass.lpszClassName;
            WindowStack.Push(this);
            //The next line did NOT work with me! When searching the web, the reason seems to be unclear! 
            //It resulted in a zero hWnd, but GetLastError resulted in zero (i.e. no error) as well !!??)
            //IntPtr hWnd = CreateWindowEx(0, wind_class.lpszClassName, "MyWnd", WS_OVERLAPPEDWINDOW | WS_VISIBLE, 0, 0, 30, 40, IntPtr.Zero, IntPtr.Zero, wind_class.hInstance, IntPtr.Zero);

            //This version worked and resulted in a non-zero hWnd
            //Rect rect;
            //Win32Api.GetWindowRect(hWnd, out rect);
            if(this.CenterForm)
            {
                int xPos = (Win32Api.GetSystemMetrics(SystemMetric.SM_CXSCREEN) - this.Width)/2;
                int yPos = (Win32Api.GetSystemMetrics(SystemMetric.SM_CYSCREEN) - this.Height)/2;
                this.Left = xPos;
                this.Top = yPos;
            }
            IntPtr hWnd = Win32Api.CreateWindowEx((int)WindowStylesConst.WS_EX_APPWINDOW,
                wndClass,
                this.Text, this.Style
                , this.Left, this.Top, this.Width, this.Height, IntPtr.Zero, IntPtr.Zero
                , windClass.hInstance, IntPtr.Zero);

            this.Handle = hWnd;
            if (hWnd == ((IntPtr) 0))
            {
                uint error = Win32Api.GetLastError();
                return false;
            }

          

            if (WindowList.ContainsKey(this.Handle))
                WindowList.Remove(this.Handle);

            WindowList.Add(this.Handle, this);
            int cmdShow = (int)ShowWindowCommands.ShowDefault;
            if(this.MaximizeForm)
                cmdShow = (int)(ShowWindowCommands.Maximize);
            if(this.MinimizeForm)
                cmdShow = (int)(ShowWindowCommands.Minimize);
            Win32Api.ShowWindowAsync(hWnd, cmdShow);
            
            
            Win32Api.UpdateWindow(hWnd);
            //Win32Api.SetWindowPos(this.Handle, (IntPtr) 0,xPos,yPos,0,0,(uint)(SetWindowPosFlags.IgnoreResize | SetWindowPosFlags.IgnoreZOrder));
            if (!this.IsMainWindow)
            {
                //The explicit message pump is not necessary, messages are obviously dispatched by the framework.
                //However, if the while loop is implemented, the functions are called... Windows mysteries...
                while (Win32Api.GetMessage(out var msg, IntPtr.Zero, 0, 0) != 0)
                {
                    Win32Api.TranslateMessage(ref msg);
                    Win32Api.DispatchMessage(ref msg);
                }
            }

            return true;
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
                    InvokeEvent(msg, hWnd,wParam , lParam );
                    SetWindowDestroyed(hWnd);
                    

                    break;


                case WindowsMessages.WM_DESTROY:

                    //If you want to shutdown the application, call the next function instead of DestroyWindow

                    Win32Api.PostQuitMessage(0);
                    break;

                default:
                    if (!InvokeEvent(msg, hWnd,wParam , lParam))
                            return Win32Api.DefWindowProc(hWnd, msg, wParam, lParam);
                    else
                        if(_lastMessageReturn != IntPtr.Zero)
                            return _lastMessageReturn;
                        else
                    break;
            }

            return IntPtr.Zero;
        }

        private void Destroy()
        {

            foreach (var item in this.Controls)
            {
               item.Value.Destroy();
            }

            Win32Api.DestroyWindow(this.Handle);
            if (Win32Api.UnregisterClass(this.Name, Process.GetCurrentProcess().Handle))
                Debug.WriteLine("Windows unreigistered!:" + this.Name);
            else
                Debug.WriteLine("Window not unregistred!:" + this.Name);
            this.Handle = IntPtr.Zero;
        }

        private static void SetWindowDestroyed(IntPtr hWnd)
        {
            if (WindowList.ContainsKey(hWnd))
            {
                Win32Window win32Window = WindowList[hWnd];
                bool isMainWindow = win32Window.IsMainWindow;
                win32Window.Destroy();

                WindowList.Remove(hWnd);
                if (isMainWindow)
                    foreach (var window in WindowList.Values)
                    {
                        IntPtr hand = window.Handle;
                        window.Destroy();
                        WindowList.Remove(hand);
                    }
            }
        }

        private static bool InvokeEvent(uint eventType, IntPtr hWnd,IntPtr wParam, IntPtr lParam)
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
                  case WindowsMessages.WM_COMMAND:
                    int controlId = Win32Api.LoWord(wParam.ToInt32());
                    uint command = (uint)Win32Api.HiWord(wParam.ToInt32());
                    IntPtr hWndControl = lParam;
                    if (window.Controls.ContainsKey(controlId))
                    {
                        IControl control = window.Controls[controlId];
                        handled = control.HandleEvents(hWnd, hWndControl, controlId, command, wParam, lParam);
                    }
                    else
                    {
                        handled = false;    
                    }
                    
                    
                    break;
                case WindowsMessages.WM_CREATE:
                    
                    foreach (IControl windowControl in window.Controls.Values)
                    {
                        windowControl.Create(hWnd);
                    }

                    window.OnCreate();
                    _lastMessageReturn = new IntPtr(0);
                    break;
                case WindowsMessages.WM_PAINT:
                    Paintstruct ps;
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

                case WindowsMessages.WM_CTLCOLOREDIT:
                    IntPtr editCtlHdc = wParam;
                    int editControlId = Win32Api.GetDlgCtrlID(lParam);
                    _lastMessageReturn = Win32Api.CreateSolidBrush(Tools.ColorTool.White);
                     if(window.Controls.ContainsKey(editControlId))
                    {
                        IControl control = window.Controls[editControlId];
                        Win32Api.SetTextColor(editCtlHdc, control.ForeColor);
                        Win32Api.SetBkColor(editCtlHdc, control.BackColor);
                        IntPtr brush = Win32Api.CreateSolidBrush(control.BackColor);    
                        _lastMessageReturn = brush;
                    }
                    handled = true;
                    break;
                case WindowsMessages.WM_CTLCOLORSTATIC:
                    IntPtr staticCtlHdc = wParam;
                    int staticControlId = Win32Api.GetDlgCtrlID(lParam);
                    _lastMessageReturn = Win32Api.CreateSolidBrush(Tools.ColorTool.White);
                    if(window.Controls.ContainsKey(staticControlId))
                    {
                        IControl control = window.Controls[staticControlId];
                        Win32Api.SetTextColor(staticCtlHdc, control.ForeColor);
                        Win32Api.SetBkColor(staticCtlHdc, control.BackColor);
                        IntPtr brush = Win32Api.CreateSolidBrush(control.BackColor);    
                        _lastMessageReturn = brush;
                    }
                    
                    handled = true;
                    break;

                case WindowsMessages.WM_CTLCOLORBTN:
                    IntPtr btnCtlHdc = wParam;
                    int btnControlId = Win32Api.GetDlgCtrlID(lParam);
                    _lastMessageReturn = Win32Api.CreateSolidBrush(Tools.ColorTool.White);
                    if(window.Controls.ContainsKey(btnControlId))
                    {
                        IControl control = window.Controls[btnControlId];
                        Win32Api.SetTextColor(btnCtlHdc, control.ForeColor);
                        Win32Api.SetBkColor(btnCtlHdc, control.BackColor);
                        IntPtr brush = Win32Api.CreateSolidBrush(control.BackColor);    
                        _lastMessageReturn = brush;
                    }
                    
                    handled = true;
                    break;
              
                case WindowsMessages.WM_SIZE:

                    handled = false;
                    break;

                default:
                    handled = false;
                    break;
            }

            return handled;
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

        public Wndclassex WindowClass { get; set; }
    }
}