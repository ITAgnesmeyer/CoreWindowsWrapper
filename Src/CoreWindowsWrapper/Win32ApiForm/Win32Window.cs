using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Diga.Core.Api.Win32;
using Diga.Core.Api.Win32.GDI;
using Point = Diga.Core.Api.Win32.Point;
// ReSharper disable CheckNamespace

namespace CoreWindowsWrapper.Win32ApiForm
{

    internal sealed class Win32Window : IWindowClass, IDisposable
    {
        private const uint WM_PARENTRESIZE = WindowsMessages.WM_USER + 975;
        public bool IsPanel { get; set; }
        public bool IsMainWindow { get; set; }
        public event EventHandler<BeforeWindowCreateEventArgs> BeforeCreate;
        public event EventHandler<CreateEventArgs> CreateForm;
        public event EventHandler<MouseClickEventArgs> DoubleClick;
        public event EventHandler<MouseClickEventArgs> Click;
        public event EventHandler<MouseClickPositionEventArgs> MouseDown;
        public event EventHandler<MouseClickPositionEventArgs> MouseUp;
        public event EventHandler<CreateEventArgs> Destroyed;
        public event EventHandler<SizeEventArgs> Size;
        public event EventHandler<PaintEventArgs> Paint;
        public event EventHandler<MouseMoveEventArgs> MouseMove;
        public event EventHandler<NativeKeyEventArgs> KeyDown;
        public event EventHandler<NativeKeyEventArgs> KeyUp;
        public event EventHandler<NativeKeyEventArgs> SysKeyDown;
        public event EventHandler<EventArgs> ParentResize;

        internal static readonly Dictionary<IntPtr, Win32Window> WindowList = new Dictionary<IntPtr, Win32Window>();
        private static readonly Stack<Win32Window> WindowStack = new Stack<Win32Window>();
        private static readonly Stack<IntPtr> GdiObjects = new Stack<IntPtr>();
        private static ApiHandleRef InstanceHandle { get; set; } = IntPtr.Zero;
        public ControlCollection Controls { get; private set; }
        private readonly MenuItemCollection _FlatMenuItems;
        public ApiHandleRef Handle { get; private set; } = IntPtr.Zero;
        public ApiHandleRef ParentHandle { get; set; } = IntPtr.Zero;
        public ApiHandleRef AcceleratorTableHandle { get; set; } = IntPtr.Zero;
        public int Color { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        private string WindowClassName { get; set; }
        private ApiHandleRef StatusBarHandle { get; set; } = IntPtr.Zero;
        private ApiHandleRef ToolBarHandle { get; set; } = IntPtr.Zero;

        private bool _Visible;
        private Task _DispatchTask;
        public static int DispatchCounter { get; internal set; }
        private static ApiHandleRef TryGetMainWindow()
        {
            ApiHandleRef mainHwnd = IntPtr.Zero;
            foreach (KeyValuePair<IntPtr, Win32Window> keyValuePair in WindowList)
            {
                if (keyValuePair.Value.IsMainWindow)
                {
                    
                    mainHwnd = keyValuePair.Key;
                    break;
                }
            }

            return mainHwnd;
        }
        public void LoadAccelrators(int id)
        {
         
            ResourceLoader loader = new ResourceLoader();
            this.AcceleratorTableHandle = loader.LoadAccelerator(id);
        }
        private void SetWindowVisible(bool visible)
        {
            if (!this.Handle.IsValid) return;
            ShowWindowCommands cmd = ShowWindowCommands.Show;
            if (visible == false)
                cmd = ShowWindowCommands.Hide;
            User32.ShowWindow(this.Handle, (int)cmd);
        }

        public Point Location
        {
            get => new Point() { X = this.Left, Y = this.Top };
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
        public bool StatusBar { get; set; }
        public bool ToolBar { get; set; } = false;

        public bool Enable
        {
            get => User32.IsWindowEnabled(this.Handle);
            set => User32.EnableWindow(this.Handle, value);
        }

        private static IntPtr _lastMessageReturn = IntPtr.Zero;
        public DockType DockType { get; set; } = DockType.None;
        private readonly WndProc _DelegateWndProc = WndProc;
        private readonly WndProc _HookWndProc = HookWndProc;
        private readonly ApiHandleRef _OrgWndProc = IntPtr.Zero;
        public bool IsHookedWindow { get; set; }
        private int _Left = unchecked((int)0x80000000);
        private int _Top = unchecked((int)0x80000000);
        private int _Width = unchecked((int)0x80000000);
        private int _Height = unchecked((int)0x80000000);
        public IMenuItem Menu { get; set; }
        private uint Style { get; set; } = WindowStylesConst.WS_OVERLAPPEDWINDOW | WindowStylesConst.WS_VISIBLE;
        private uint ClassStyle { get; set; } = (uint)(ClassStyles.CS_HREDRAW | ClassStyles.CS_VREDRAW | ClassStyles.CS_DBLCLKS);
        private uint StyleEx { get; set; } = (int)(WindowStylesConst.WS_EX_APPWINDOW | WindowStylesConst.WS_EX_CLIENTEDGE);
        public static Win32Window CreateAsHook(IntPtr hookHandle)
        {
            return new Win32Window(hookHandle);
        }



        [HandleProcessCorruptedStateExceptions]
        private void SetClassInfo(string className)
        {
            try
            {
                User32.GetClassInfoEx(Win32Window.InstanceHandle, className, out WndclassEx wclass);
                this.WindowClass = wclass;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
        }
        private Win32Window(IntPtr hookHandle)
        {
            this.Handle = hookHandle;
            this.Controls = new ControlCollection(this);
            this._FlatMenuItems = new MenuItemCollection();
            this.IsMainWindow = false;
            this.IsHookedWindow = true;
            IntPtr windProcPtr = Marshal.GetFunctionPointerForDelegate(this._HookWndProc);
            string className = User32.GetClassName(hookHandle);

            this.WindowClassName = className;
            this.Name = className;


            User32.GetWindowThreadProcessId(hookHandle, out uint procId);
            var process = Process.GetProcessById((int)procId);
            Win32Window.InstanceHandle = process.Handle;


            SetClassInfo(className);



            this.ParentHandle = User32.GetWindowLongPtr(hookHandle, GWL.GWL_HWNDPARENT);
            IntPtr stylePtr = User32.GetWindowLongPtr(hookHandle, GWL.GWL_EXSTYLE);
            this.Style = (uint)stylePtr.ToInt32();
            if (User32.GetWindowRect(hookHandle, out Rect rect))
            {
                this._Left = rect.Left;
                this._Top = rect.Top;
                this._Width = rect.Width;
                this._Height = rect.Height;
            }


            if (WindowList.ContainsKey(this.Handle))
                WindowList.Remove(this.Handle);

            WindowList.Add(this.Handle, this);

            this._OrgWndProc = User32.SetWindowLongPtr(hookHandle, GWL.GWL_WNDPROC, windProcPtr);


        }


        public Win32Window(bool isMainWindow = false)
        {
            this.Controls = new ControlCollection(this);
            this._FlatMenuItems = new MenuItemCollection();
            this.IsMainWindow = isMainWindow;
            this.Name = "Win32WindowClass";
            this.Text = this.Name;
            this.Color = 0xF0F0F0;
        }

        public Win32Window(IntPtr parentHandle, bool isMainWindow = false, bool isPanel = false, DockType dockType = DockType.None)
        {
            this.Controls = new ControlCollection(this);
            this._FlatMenuItems = new MenuItemCollection();
            this.IsMainWindow = isMainWindow;
            this.ParentHandle = parentHandle;
            this.Name = "Win32WindowClass";
            this.Text = this.Name;
            this.Color = 0xF0F0F0;
            this.IsPanel = isPanel;
            this.DockType = dockType;
        }

        public Rect GetClientRect()
        {
            Rect rect = new Rect(this.Left, this.Top, this.Width, this.Height);
            if (User32.GetClientRect(this.Handle, out Rect rc))
            {
                rect = rc;
            }
            return rect;
        }


        private void MoveMyWindow()
        {
            if (!this.Handle.IsValid) return;
            User32.MoveWindow(this.Handle, this.Left, this.Top, this.Width, this.Height, true);
        }

        internal void Close()
        {
            User32.SendMessage(this.Handle, WindowsMessages.WM_CLOSE);
        }

        internal bool Create(bool asControl = false)
        {
            this.WindowClassName = this.Name + "_" + WindowList.Count;
            WndclassEx windClass = new WndclassEx
            {
                cbSize = Marshal.SizeOf(typeof(WndclassEx)),
                style = this.ClassStyle,
                hbrBackground = Gdi32.GetStockObject(StockObjects.WHITE_BRUSH),
                cbClsExtra = 0,
                cbWndExtra = 0,
                hInstance = Process.GetCurrentProcess().Handle,
                hIcon = string.IsNullOrEmpty(this.IconFile) ? Tools.ImageTool.LoadAppIcon() : Tools.ImageTool.SafeLoadIconFromFile(this.IconFile),
                hCursor = User32.LoadCursor(IntPtr.Zero, (int)Win32ApiCursors.IDC_ARROW),
                lpszMenuName = null,
                lpszClassName = this.WindowClassName,
                //lpfnWndProc = Marshal.GetFunctionPointerForDelegate(this._DelegateWndProc),
                lpfnWndProc = this._DelegateWndProc,
                hIconSm = IntPtr.Zero
            };
            //Doubleclicks are active
            //Black background, +1 is necessary
            // alternative: Process.GetCurrentProcess().Handle;
            // Crosshair cursor;


            Win32Window.InstanceHandle = windClass.hInstance;
            IntPtr hMenu = IntPtr.Zero;
            if (this.Menu != null)
            {
                this.Menu.Create(hMenu);
                hMenu = this.Menu.ParentMenuHandle;

                FillFlatMenuItemList(this.Menu);
            }

            List<int> keys = new List<int>();
            foreach (int controlsKey in this.Controls.Keys)
            {
                keys.Add(controlsKey);
            }

            foreach (var item in keys)
            {
                FlattenControlItems(this.Controls[item]);
            }

            windClass.hbrBackground = Gdi32.CreateSolidBrush(this.Color);
            this.WindowClass = windClass;
            OnBeforeFormCreate();
            ushort regResult = User32.RegisterClassEx(ref windClass);

            if (regResult == 0)
            {
                // ReSharper disable once UnusedVariable
                uint error = Kernel32.GetLastError();
                Win32Exception ex = new Win32Exception((int)error);
                Debug.Print(ex.Message);
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
                int xPos = (User32.GetSystemMetrics(SystemMetric.SM_CXSCREEN) - this.Width) / 2;
                int yPos = (User32.GetSystemMetrics(SystemMetric.SM_CYSCREEN) - this.Height) / 2;
                this.Left = xPos;
                this.Top = yPos;
            }

            IntPtr hWnd = User32.CreateWindowEx(
                this.StyleEx,
                this.WindowClassName,
                this.Text, this.Style
                , this.Left, this.Top, this.Width, this.Height, this.ParentHandle, hMenu
                , windClass.hInstance, IntPtr.Zero);


            this.Handle = hWnd;
            if (hWnd == ((IntPtr)0))
            {
                // ReSharper disable once UnusedVariable
                uint error = Kernel32.GetLastError();
                Win32Exception ex = new Win32Exception((int)error);
                Debug.Print(ex.Message);
                return false;
            }

            if (asControl)
            {
                if (this.ParentHandle.IsValid)
                    User32.SetParent(this.Handle, this.ParentHandle);
            }

            if (WindowList.ContainsKey(this.Handle))
                WindowList.Remove(this.Handle);

            WindowList.Add(this.Handle, this);
            int cmdShow = (int)ShowWindowCommands.ShowDefault;
            if (this.MaximizeForm)
                cmdShow = (int)(ShowWindowCommands.Maximize);
            if (this.MinimizeForm)
                cmdShow = (int)(ShowWindowCommands.Minimize);
            User32.ShowWindowAsync(hWnd, cmdShow);


            User32.UpdateWindow(hWnd);


            OnCreate();

            if (!this.IsMainWindow)
            {
                //CreateDispatchTask();
            }

            return true;
        }

        private void OnBeforeFormCreate()
        {
            BeforeWindowCreateEventArgs ev = new BeforeWindowCreateEventArgs(this.Style, this.StyleEx);
            OnBeforeCreate(ev);
            this.Style = ev.Styles.Style;
            this.StyleEx = ev.Styles.StyleEx;

        }

        public void UpdateStyle(uint style)
        {
            IntPtr p = new IntPtr(style);
            //this.Style = style;
            User32.SetWindowLongPtr(this.Handle, GWL.GWL_STYLE, p);

        }

        public void UpdateWidow()
        {
            User32.SetWindowPos(this.Handle, IntPtr.Zero, 0, 0, 0, 0,
                (uint)DeferWindowPosCommands.SWP_FRAMECHANGED | (uint)DeferWindowPosCommands.SWP_NOMOVE |
                (uint)DeferWindowPosCommands.SWP_NOSIZE | (uint)DeferWindowPosCommands.SWP_NOZORDER |
                (uint)DeferWindowPosCommands.SWP_NOOWNERZORDER);
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
        public void SetWindowState(WindowState state)
        {
            switch (state)
            {
                case WindowState.Normal:
                    User32.ShowWindow(this.Handle, (int)WindowState.Normal);
                    break;
                case WindowState.Maximized:
                    User32.ShowWindow(this.Handle, (int)WindowState.Maximized);
                    break;
                case WindowState.Minimized:
                    User32.ShowWindow(this.Handle, (int)WindowState.Minimized);
                    break;
            }
        }

        public WindowState GetWindowState()
        {
            WindowPlacement wp = new WindowPlacement();
            User32.GetWindowPlacement(this.Handle, ref wp);
            if (wp.showCmd == (uint)ShowWindowCommands.Maximize || wp.showCmd == (uint)ShowWindowCommands.ShowMaximized)
            {
                return WindowState.Maximized;
            }

            if (wp.showCmd == (uint)ShowWindowCommands.Minimize || wp.showCmd == (uint)ShowWindowCommands.ShowMinimized)
            {
                return WindowState.Minimized;
            }

            return WindowState.Normal;

        }
        private void CreateDispatchTask()
        {
            this._DispatchTask = new Task(Dispatch);
            this._DispatchTask.Start();
        }

        private void FlattenControlItems(IControl control)
        {
            if (control is NativeWindow)
                return;
            if (!this.Controls.ContainsKey(control.ControlId))
                this.Controls.Add(control);
            foreach (var controlControl in control.Controls.Values)
            {
                FlattenControlItems(controlControl);
            }
           
            control.Controls.Clear();
           
            
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
                this._FlatMenuItems.Add(men);
                if (men != null)
                    foreach (var menuItem in men.Items.Values)
                    {
                        FillFlatMenuItemList(menuItem);
                    }
            }
        }
        [HandleProcessCorruptedStateExceptions]
        public void Dispatch()
        {
            DispatchCounter++;
            //lock (this)
            //{
                int br = 0;
                ApiHandleRef mainWindowHandle = TryGetMainWindow();
                while ((br = User32.GetMessage(out var msg, IntPtr.Zero, 0, 0)) != 0)
                {
                    if (!mainWindowHandle.IsValid)
                        mainWindowHandle = TryGetMainWindow();

                    try
                    {
                        if (br == -1)
                        {
                            // handle the error and possibly exit
                            Debug.Print("GetMessage returns -1");
                        }
                        else
                        {
                            if (mainWindowHandle.IsValid)
                            {

                                if (!User32.IsDialogMessage(mainWindowHandle, ref msg))
                                {

                                    User32.TranslateMessage(ref msg);
                                    if (msg.hwnd != IntPtr.Zero)
                                    {
                                        User32.DispatchMessage(ref msg);
                                    }
                                }
                            }
                            else
                            {
                                User32.TranslateMessage(ref msg);
                                User32.DispatchMessage(ref msg);

                            }
                        }

                    }
                    catch (AccessViolationException vex)
                    {
                        Debug.Print(vex.ToString());
                        Console.WriteLine("AccessViolationException=>" + vex.StackTrace);
                    }
#pragma warning disable 618
                    catch (ExecutionEngineException e)
#pragma warning restore 618
                    {
                        Console.WriteLine("ExecutionEngineException=>" + e.StackTrace);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception=>" + e.Message + "--Stack:" + e.StackTrace);
                    }
                    if (WindowList.Count == 0) break;
                }
            //}

            DispatchCounter--;
        }

        private static IntPtr HookWndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
        {
            if (WindowList.ContainsKey(hWnd))
            {
                var win = WindowList[hWnd];
                if (win.IsHookedWindow)
                {

                    IntPtr rsult = WndProc(hWnd, msg, wParam, lParam);
                    if (Win32Api.GetIntPtrUInt(rsult) == 0)
                    {
                        return User32.CallWindowProc(win._OrgWndProc, hWnd, (int)msg, wParam, lParam);
                    }

                    return rsult;
                }
            }

            return User32.DefWindowProc(hWnd, msg, wParam, lParam);
        }

        private static IntPtr WndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
        {



            switch (msg)
            {
               

                case WindowsMessages.WM_CLOSE:
                    InvokeEvent(msg, hWnd, wParam, lParam);
                    SetWindowDestroyed(hWnd);


                    break;


                case WindowsMessages.WM_DESTROY:

                    //If you want to shutdown the application, call the next function instead of DestroyWindow
                    if (!WindowList.ContainsKey(hWnd))
                        User32.PostQuitMessage(0);
                    else
                    {
                        Win32Window window = WindowList[hWnd];
                        if (window.IsMainWindow)
                            User32.PostQuitMessage(0);
                    }


                    break;

                default:
                    if (msg == WindowsMessages.WM_PAINT)
                        Debug.Print("Paint");
                    if (!InvokeEvent(msg, hWnd, wParam, lParam))
                    {
                        if (WindowList.ContainsKey(hWnd))
                        {
                            var win = WindowList[hWnd];
                            if (win.IsHookedWindow)
                            {
                                return new IntPtr(0);
                            }
                        }
                        else
                        {
                            if(WindowList.Count > 0)
                                Debug.Print("Window not found!");
                        }

                        return User32.DefWindowProc(hWnd, msg, wParam, lParam);
                    }
                    else if (_lastMessageReturn != IntPtr.Zero)
                        return _lastMessageReturn;
                    else
                        break;
            }

            return new IntPtr(0);
        }

        private void Destroy()
        {
            OnDestroy(new CreateEventArgs(this.Handle));
            foreach (var item in this.Controls)
            {
                item.Value.Destroy();
            }

            this.Menu?.Destroy();
            if (this.ToolBarHandle.IsValid) User32.DestroyWindow(this.ToolBarHandle);
            if (this.StatusBarHandle.IsValid) User32.DestroyWindow(this.StatusBarHandle);
            User32.DestroyWindow(this.Handle);

            if (User32.UnregisterClass(this.WindowClassName, Process.GetCurrentProcess().Handle))
                Debug.WriteLine("Windows unreigistered!:" + this.WindowClassName);
            else
                Debug.WriteLine("Window not unregistred!:" + this.WindowClassName);
            this.Handle = IntPtr.Zero;
        }

        public bool Visible
        {
            get => this._Visible;
            set
            {
                this._Visible = value;
                SetWindowVisible(this._Visible);
            }

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
        private const uint SC_CLOSE = 0xF060;

        private static bool InvokeEvent(uint eventType, IntPtr hWnd, IntPtr wParam, IntPtr lParam)
        {
            bool handled = true;
            while (GdiObjects.Count > 0)
            {
                IntPtr gdiObj = GdiObjects.Pop();
                Gdi32.DeleteObject(gdiObj);
            }


            _lastMessageReturn = IntPtr.Zero;
            Win32Window window;
            if (eventType == WindowsMessages.WM_CREATE)
            {
                window = WindowStack.Pop();
                window.Handle = hWnd;
            }
            else
            {

                if (!WindowList.ContainsKey(hWnd)) 
                    return false;
                window = WindowList[hWnd];
            }


            switch (eventType)
            {
                case WindowsMessages.WM_SYSKEYDOWN:

                    var kevSysDown = new NativeKeyEventArgs(wParam, lParam);
                    window.OnSysteKeyDown(hWnd, kevSysDown);
                    handled = kevSysDown.Handled;
                    //_lastMessageReturn = new IntPtr(1);
                    break;
                case WindowsMessages.WM_NOTIFY:
                    NmHdr hdr = null;
                    try
                    {
                        hdr = Marshal.PtrToStructure<NmHdr>(lParam);
                    }
                    catch (Exception e)
                    {
                        Debug.Print(e.Message);
                    }

                    if (hdr != null)
                    {

                        int cId = (int)hdr.idFrom;
                        uint cCmd = Win32Api.GetIntPtrUInt(hdr.code);
                        IntPtr hCWndControl = hdr.hwndFrom;

                        if (window.Controls.ContainsKey(cId))
                        {
                            IControl cControl = window.Controls[cId];
                            Debug.Print("Control Type=>" + cControl.ControlType + ",ID=>" + cId + ",cmd=>0x" + cCmd.ToString("x4") + "=>" + cCmd);
                            handled = cControl.HandleEvents(hWnd, hCWndControl, cId, cCmd, wParam, lParam);

                        }
                    }

                    break;
                case WindowsMessages.WM_COMMAND:
                    int controlId = Win32Api.LoWord(wParam.ToInt32());
                    int cmdInt = Win32Api.HiWord(wParam.ToInt32());
                    if (cmdInt <= 0)
                        Debug.Print($"ControlId({controlId}) command-int({cmdInt})");
                    uint command = (uint)Win32Api.HiWord(wParam.ToInt32());
                    IntPtr hWndControl = lParam;
                    if (window.Controls.ContainsKey(controlId))
                    {
                        IControl control = window.Controls[controlId];
                        handled = control.HandleEvents(hWnd, hWndControl, controlId, command, wParam, lParam);
                    }
                    else
                    {
                        if (window._FlatMenuItems.ContainsKey(controlId))
                        {
                            IMenuItem menu = window._FlatMenuItems[controlId];
                            handled = menu.HandleEvents(hWnd, hWndControl, controlId, command, wParam, lParam);
                        }
                        else
                        {
                            handled = false;
                        }
                    }


                    break;
                case WindowsMessages.WM_CREATE:

                    if (window.StatusBar)
                    {
                        IntPtr sbId = new IntPtr(100);
                        window.StatusBarHandle = User32.CreateWindowEx(0, "msctls_statusbar32", null,
                            (uint)(WindowStyles.WS_VISIBLE | WindowStyles.WS_CHILD), 0, 0, 0, 0, hWnd, sbId,
                            Win32Window.InstanceHandle, IntPtr.Zero);
                        User32.ShowWindow(window.StatusBarHandle, (int)ShowWindowCommands.Show);
                    }


                    if (window.ToolBar)
                    {
                        //IntPtr tbId = new IntPtr(101);
                        window.ToolBarHandle = User32.CreateWindowEx(0, "ToolbarWindow32", null,
                            WindowStylesConst.WS_CHILD | 512, 0,
                            0, 0, 0, hWnd, IntPtr.Zero, Win32Window.InstanceHandle, IntPtr.Zero);

                        User32.AddTbButton(window.ToolBarHandle, "Test", 50);
                        //Win32Api.AddTbButton(window.ToolBarHandle, "Test2", 51);
                        User32.ShowWindow(window.ToolBarHandle, (int)ShowWindowCommands.Show);
                    }


                    foreach (IControl windowControl in window.Controls.Values)
                    {
                        windowControl.Create(hWnd);
                    }


                    _lastMessageReturn = new IntPtr(1);
                    break;
                case WindowsMessages.WM_KEYUP:
                    var kevUp = new NativeKeyEventArgs(wParam, lParam);
                    window.OnKeyUp(hWnd, kevUp);
                    handled = kevUp.Handled;
                    break;
                case WindowsMessages.WM_KEYDOWN:
                    var kevDown = new NativeKeyEventArgs(wParam, lParam);
                    window.OnKeyDown(hWnd, kevDown);
                    handled = kevDown.Handled;
                    break;

                case WindowsMessages.WM_PAINT:
                    //PaintStruct ps;
                    using(var p = new ApiStructHandleRef<PaintStruct>())
                    {
                        IntPtr hdc = User32.BeginPaint(hWnd, p);
                        window.OnPaint(hWnd, p.GetStruct());
                        User32.EndPaint(hWnd, p);
                        User32.ReleaseDC(hWnd, hdc);

                    }
                    // ReSharper disable once UnusedVariable
                    break;
                case WindowsMessages.WM_LBUTTONDBLCLK:
                    window.OnDoubleClick(new MouseClickEventArgs(MouseButton.Left, hWnd));

                    break;
                case WindowsMessages.WM_LBUTTONDOWN:
                    {
                        window.OnClick(new MouseClickEventArgs(MouseButton.Left, hWnd));
                        HighLow hilo = Win32Api.MakeHiLo(lParam);
                        Point pt = hilo;
                        MouseKey key = (MouseKey)Win32Api.GetIntPtrUInt(wParam);
                        window.OnMouseDown(new MouseClickPositionEventArgs(MouseButton.Left, hWnd, pt, key));
                    }

                    break;
                case WindowsMessages.WM_LBUTTONUP:
                    {
                        HighLow hilo = Win32Api.MakeHiLo(lParam);
                        Point pt = hilo;
                        MouseKey key = (MouseKey)Win32Api.GetIntPtrUInt(wParam);
                        window.OnMouseUp(new MouseClickPositionEventArgs(MouseButton.Left, hWnd, pt, key));

                    }

                    break;

                case WindowsMessages.WM_RBUTTONDBLCLK:
                    window.OnDoubleClick(new MouseClickEventArgs(MouseButton.Right, hWnd));
                    break;
                case WindowsMessages.WM_RBUTTONDOWN:
                    {
                        HighLow hilo = Win32Api.MakeHiLo(lParam);
                        Point pt = hilo;
                        MouseKey key = (MouseKey)Win32Api.GetIntPtrUInt(wParam);
                        window.OnClick(new MouseClickEventArgs(MouseButton.Right, hWnd));
                        window.OnMouseDown(new MouseClickPositionEventArgs(MouseButton.Right, hWnd, pt, key));
                    }

                    break;
                case WindowsMessages.WM_RBUTTONUP:
                    {
                        HighLow hilo = Win32Api.MakeHiLo(lParam);
                        Point pt = hilo;
                        MouseKey key = (MouseKey)Win32Api.GetIntPtrUInt(wParam);
                        window.OnMouseUp(new MouseClickPositionEventArgs(MouseButton.Right, hWnd, pt, key));
                    }

                    break;
                case WindowsMessages.WM_MBUTTONDBLCLK:
                    window.OnDoubleClick(new MouseClickEventArgs(MouseButton.Middle, hWnd));
                    break;
                case WindowsMessages.WM_MBUTTONDOWN:
                    {
                        HighLow hilo = Win32Api.MakeHiLo(lParam);
                        Point pt = hilo;
                        MouseKey key = (MouseKey)Win32Api.GetIntPtrUInt(wParam);
                        window.OnMouseDown(new MouseClickPositionEventArgs(MouseButton.Middle, hWnd, pt, key));
                    }

                    break;
                case WindowsMessages.WM_MBUTTONUP:
                    {
                        HighLow hilo = Win32Api.MakeHiLo(lParam);
                        Point pt = hilo;
                        MouseKey key = (MouseKey)Win32Api.GetIntPtrUInt(wParam);
                        window.OnMouseUp(new MouseClickPositionEventArgs(MouseButton.Middle, hWnd, pt, key));
                    }

                    break;
                case WindowsMessages.WM_MOUSEMOVE:
                    HighLow hl = Win32Api.MakeHiLo(lParam);
                    uint mouseButtons = Win32Api.GetIntPtrUInt(wParam);
                    window.OnMouseMove(new MouseMoveEventArgs(new Point(hl.iLow, hl.iHigh), (MouseKey)mouseButtons));
                    break;
                case WindowsMessages.WM_HANDHELDFIRST:
                    window.OnCreate();
                    break;

                case WindowsMessages.WM_CTLCOLOREDIT:
                    CtlColors(wParam, lParam, window);
                    break;
                case WindowsMessages.WM_CTLCOLORSTATIC:
                    CtlColors(wParam, lParam, window);
                    break;

                case WindowsMessages.WM_CTLCOLORBTN:
                    CtlColors(wParam, lParam, window);
                    break;

                case WindowsMessages.WM_CTLCOLORLISTBOX:

                    CtlColors(wParam, lParam, window);
                    break;

                case WindowsMessages.WM_SIZE:
                    if (window.StatusBar)
                    {
                        User32.SendMessage(window.StatusBarHandle, WindowsMessages.WM_SIZE);
                    }

                    if (window.ToolBar)
                    {
                        User32.SendMessage(window.ToolBarHandle, WindowsMessages.WM_SIZE);
                    }
                    
                    Rect r = window.GetCleanClientRect();
                    window.OnSize(new SizeEventArgs(r.X, r.Y, r.Right - r.Left, r.Bottom - r.Top));
                    foreach (var item in window.Controls)
                    {
                        if(item.Value is NativeWindow)
                        {
                            User32.SendMessage(item.Value.Handle, WM_PARENTRESIZE);
                        }
                    }
                    //handled = false;
                    break;
                case WM_PARENTRESIZE:
                    window.OnParentResize();
                    break;
                case WindowsMessages.WM_SIZING:
                    Rect rz = window.GetCleanClientRect();
                    window.OnSize(new SizeEventArgs(rz.X, rz.Y, rz.Right - rz.Left, rz.Bottom - rz.Top));
                    break;

                case WindowsMessages.WM_MOVE:
                    Rect rzs = window.GetCleanClientRect();
                    window.OnSize(new SizeEventArgs(rzs.X, rzs.Y, rzs.Right - rzs.Left, rzs.Bottom - rzs.Top));
                    break;
                case WindowsMessages.WM_TIMER:
                    int timerId = Win32Api.LoWord(wParam.ToInt32());
                    if(window.Controls.ContainsKey(timerId))
                    {
                        IControl control = window.Controls[timerId];
                        handled = control.HandleEvents(hWnd, IntPtr.Zero, timerId, WindowsMessages.WM_TIMER, wParam, lParam);
                        
                    }
                    else
                    {
                        handled = false;
                    }
                    break;
                default:
                    handled = false;
                    break;
            }

            return handled;
        }

        private void OnKeyUp(IntPtr hWnd, NativeKeyEventArgs nativeKeyEventArgs)
        {
            KeyUp?.Invoke(this, nativeKeyEventArgs);
        }

        private static void CtlColors(IntPtr wParam, IntPtr lParam, Win32Window window)
        {
            IntPtr editCtlHdc = wParam;
            int editControlId = User32.GetDlgCtrlID(lParam);
            _lastMessageReturn = Gdi32.CreateSolidBrush(Tools.ColorTool.White);
            if (window.Controls.ContainsKey(editControlId))
            {

                IControl control = window.Controls[editControlId];

                if (control.ControlType == ControlType.ComboBox)
                {
                    ComboboxInfo cinfo = new ComboboxInfo();
                    cinfo.cbSize = (uint)Marshal.SizeOf<ComboboxInfo>();
                    if (User32.GetComboBoxInfo(control.Handle, ref cinfo))
                    {
                        Gdi32.SetBkColor(cinfo.hwndCombo, control.BackColor);
                        Gdi32.SetTextColor(cinfo.hwndCombo, control.ForeColor);
                        Gdi32.SetBkColor(cinfo.hwndItem, control.BackColor);
                        Gdi32.SetTextColor(cinfo.hwndItem, control.ForeColor);
                        Gdi32.SetBkColor(cinfo.hwndList, control.BackColor);
                        Gdi32.SetTextColor(cinfo.hwndList, control.ForeColor);
                    }
                }
                else
                {
                    Gdi32.SetTextColor(editCtlHdc, control.ForeColor);
                    Gdi32.SetBkColor(editCtlHdc, control.BackColor);
                }

                Gdi32.DeleteObject(_lastMessageReturn);
                IntPtr brush = Gdi32.CreateSolidBrush(control.BackColor);
                _lastMessageReturn = brush;
            }

            GdiObjects.Push(_lastMessageReturn);
        }


        [SuppressMessage("ReSharper", "UnusedParameter.Local")]
        private void OnPaint(IntPtr hWnd, PaintStruct ps)
        {
            //Do Something?
            OnPaint(new PaintEventArgs(new PaintObject(ps)));
        }

        private void OnSysteKeyDown(IntPtr hWnd, NativeKeyEventArgs keyEventArgs)
        {
            SysKeyDown?.Invoke(this, keyEventArgs);
        }
        private void OnKeyDown(IntPtr hWnd, NativeKeyEventArgs keyEventArgs)
        {
            KeyDown?.Invoke(this, keyEventArgs);
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

        private void OnMouseDown(MouseClickPositionEventArgs e)
        {
            MouseDown?.Invoke(this, e);
        }

        private void OnMouseUp(MouseClickPositionEventArgs e)
        {
            MouseUp?.Invoke(this, e);
        }

        private void OnDestroy(CreateEventArgs e)
        {
            Destroyed?.Invoke(this, e);
        }

        public WndclassEx WindowClass { get; set; }

        public void Dispose()
        {
            if (this.IsHookedWindow)
            {
                if (this._OrgWndProc.IsValid)
                {
                    User32.SetWindowLongPtr(this.Handle, GWL.GWL_WNDPROC, _OrgWndProc);
                }
            }

            this._DispatchTask?.Dispose();
            this.Controls?.Dispose();
            this.Controls = null;
        }

        public void AttachToWindow(IntPtr parent)
        {
            this.ParentHandle = parent;
            User32.SetParent(this.Handle, this.ParentHandle);
        }

        private void OnSize(SizeEventArgs e)
        {
            Size?.Invoke(this, e);
        }

        private void OnParentResize()
        {
            ParentResize?.Invoke(this, EventArgs.Empty);
        }
        
        public Rect GetCleanClientRect()
        {
            int sbHeigt = 0;
            int tbHeigt = 0;
            if (this.StatusBar)
            {
                User32.GetWindowRect(this.StatusBarHandle, out var sbRect);
                sbHeigt = sbRect.Bottom - sbRect.Top;
            }

            if (this.ToolBar)
            {
                User32.GetWindowRect(this.ToolBarHandle, out var tbRect);
                tbHeigt = tbRect.Bottom - tbRect.Top;
            }

            User32.GetClientRect(this.Handle, out var r);
            r.Bottom = r.Bottom - sbHeigt;
            r.Top = r.Top + tbHeigt;
            return r;
        }

        public void PostCreateControls()
        {
            IntPtr hMenu = IntPtr.Zero;
            if (this.Menu != null)
            {
                this.Menu.Create(hMenu);
                hMenu = this.Menu.ParentMenuHandle;
                User32.SetMenu(this.Handle, hMenu);
                FillFlatMenuItemList(this.Menu);
            }
        }

        private void OnPaint(PaintEventArgs e)
        {
            Paint?.Invoke(this, e);
        }

        private void OnMouseMove(MouseMoveEventArgs e)
        {
            MouseMove?.Invoke(this, e);
        }
        private void OnBeforeCreate(BeforeWindowCreateEventArgs e)
        {
            BeforeCreate?.Invoke(this, e);
        }
        public void Invlidate()
        {
            User32.RedrawWindow(this.Handle, IntPtr.Zero, IntPtr.Zero, RedrawConstants.RDW_INVALIDATE | RedrawConstants.RDW_ERASE | RedrawConstants.RDW_ALLCHILDREN | RedrawConstants.RDW_UPDATENOW);
        }
        public void Redraw()
        {
            User32.RedrawWindow(this.Handle, IntPtr.Zero, IntPtr.Zero, RedrawConstants.RDW_ERASENOW | RedrawConstants.RDW_ALLCHILDREN | RedrawConstants.RDW_FRAME);
        }
    }
}