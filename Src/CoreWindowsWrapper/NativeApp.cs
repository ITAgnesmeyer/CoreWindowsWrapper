using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Diga.Core.Api.Win32;
namespace CoreWindowsWrapper
{
    public static class NativeApp
    {
        private static NativeWindow _mainWindow;

        /// Return Type: BOOL->int
        ///hObj: HANDLE->void*
        ///nIndex: int
        ///pvInfo: PVOID->void*
        ///nLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetUserObjectInformationW",CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern uint SetUserObjectInformationW([In()] IntPtr hObj, int nIndex, [In()] int pvInfo, uint nLength);
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
        public static extern IntPtr GetCurrentProcess();
        private const int UOI_FLAGS = 1;
        private const int UOI_TIMERPROC_EXCEPTION_SUPPRESSION = 7;

        public static bool ExceptInEvents = false;
       
        public static void Run(NativeWindow window)
        {
            //User32.EnableVisualStyles();
            //int sz = sizeof(bool);
            //IntPtr ip = GetCurrentProcess();
            //uint v = SetUserObjectInformationW(ip, UOI_TIMERPROC_EXCEPTION_SUPPRESSION, 0,(uint)Marshal.SizeOf<bool>());
            //try
            //{
            //    if (v == 0)
            //    {
            //        int err = Marshal.GetLastWin32Error();
            //        int hr = Marshal.GetHRForLastWin32Error();
            //        Marshal.ThrowExceptionForHR(hr);

            //    }
            //}
            //catch (Exception ex)
            //{
            //    Debug.Print(ex.Message);

            //}
            NativeTheaming.InitTheaming();
            _mainWindow = window;
            _mainWindow.IsMainWindow = true;
            _mainWindow.Show();

            //Task t = new Task(TaskAction);
            //t.RunSynchronously();
            Dispatch();
        }
        private static IntPtr GetRealParentHp(IntPtr hWnd)
        {
            IntPtr hWndOwner;
            if(IntPtr.Zero != (hWndOwner = User32.GetWindow(hWnd, GetWindowFlag.GW_OWNER)))
            {
                return hWndOwner;
            }

            return User32.GetAncestor(hWnd, 1);
        }
        private static IntPtr GetRealParent(IntPtr hWnd)
        {
            IntPtr hDesk = User32.GetDesktopWindow();
            IntPtr hWndOwner = GetRealParentHp(hWnd);
            if(hDesk == hWndOwner)
            {
                return IntPtr.Zero;
            }
            return hWndOwner;
        }
        private static volatile bool _StopModalDispatch = false;
        internal static volatile bool _ModalDispatchIsRunning = false;
        public static void StopModalDispatch()
        {
            _StopModalDispatch = true;
            //User32.PostMessage(_mainWindow.Handle, WindowsMessages.WM_ACTIVATE,IntPtr.Zero,IntPtr.Zero);
        }
        private static Stack<Action> _ModalActionstack = new Stack<Action>();

        internal static void RunModalDispatch()
        {
            var action = new Action(ModalDispatch);

            _ModalActionstack.Push(action);

            action();
            _ModalActionstack.Pop();
            

        }

        internal static  void ModalDispatch()
        {
            _ModalDispatchIsRunning = true;
            //IntPtr hAccel = IntPtr.Zero;
            int ret;
            while (!_StopModalDispatch)
            {
                if ((ret = User32.GetMessage(out MSG msg, IntPtr.Zero, 0, 0)) > 0)
                {


                    if (ret == -1)
                    {
                        //return;
                    }
                    else
                    {

                        if (NativeWindow.TryGetWindow(msg.hwnd, out NativeWindow nw))
                        {
                            if (nw.ParentHandle != IntPtr.Zero)
                            {
                                if ((User32.TranslateAccelerator(nw.ParentHandle, _mainWindow.Accelerators, ref msg) == 0) && (!User32.IsDialogMessage(nw.ParentHandle, ref msg)))
                                {
                                    User32.TranslateMessage(ref msg);
                                    User32.DispatchMessage(ref msg);

                                }
                            }
                            else
                            {
                                // && (!User32.IsDialogMessage(nw.Handle, ref msg)
                                if ((User32.TranslateAccelerator(nw.Handle, nw.Accelerators, ref msg) == 0))
                                {
                                    User32.TranslateMessage(ref msg);
                                    User32.DispatchMessage(ref msg);

                                }

                            }
                        }
                        else
                        {

                            IntPtr hParent = GetRealParent(msg.hwnd);
                            //if(NativeWindow.TryGetWindow(hParent, out NativeWindow n))
                            //{
                            //    Debug.Print("TEST");
                            //}
                            if (hParent != IntPtr.Zero)
                            {

                                if ((User32.TranslateAccelerator(hParent, _mainWindow.Accelerators, ref msg) == 0) && (!User32.IsDialogMessage(hParent, ref msg)))
                                {
                                    User32.TranslateMessage(ref msg);
                                    User32.DispatchMessage(ref msg);

                                }


                            }
                            else
                            {
                                IntPtr hWndActive = User32.GetActiveWindow();
                                if (hWndActive != IntPtr.Zero)
                                {
                                    if ((User32.TranslateAccelerator(hWndActive, _mainWindow.Accelerators, ref msg) == 0) && (!User32.IsDialogMessage(hWndActive, ref msg)))
                                    {
                                        User32.TranslateMessage(ref msg);
                                        User32.DispatchMessage(ref msg);

                                    }

                                }
                                else
                                {
                                    if ((User32.TranslateAccelerator(_mainWindow.Handle, _mainWindow.Accelerators, ref msg) == 0) && (!User32.IsDialogMessage(_mainWindow.Handle, ref msg)))
                                    {
                                        User32.TranslateMessage(ref msg);
                                        User32.DispatchMessage(ref msg);

                                    }
                                }
                            }

                        }

                        //if (User32.TranslateAccelerator(_mainWindow.Handle, _mainWindow.Accelerators, ref msg) == 0)
                        //{

                        //        User32.TranslateMessage(ref msg);
                        //        User32.DispatchMessage(ref msg);


                        //}
                    }
                }
            }
            _ModalDispatchIsRunning = false;
            _StopModalDispatch = false;
        }
        private static void Dispatch()
        {
            
            //IntPtr hAccel = IntPtr.Zero;
            int ret;
            while((ret = User32.GetMessage(out MSG msg, IntPtr.Zero, 0,0)) > 0)
            {
               
                if (ret == -1)
                {
                    //return;
                }
                else
                {

                    if(NativeWindow.TryGetWindow(msg.hwnd, out NativeWindow nw))
                    {
                        if (nw.ParentHandle != IntPtr.Zero)
                        {
                            if ((User32.TranslateAccelerator(nw.ParentHandle, _mainWindow.Accelerators, ref msg) == 0) && (!User32.IsDialogMessage(nw.ParentHandle, ref msg)))
                            {
                                User32.TranslateMessage(ref msg);
                                User32.DispatchMessage(ref msg);

                            }
                        }
                        else
                        {
                            // && (!User32.IsDialogMessage(nw.Handle, ref msg)
                            if ((User32.TranslateAccelerator(nw.Handle, nw.Accelerators, ref msg) == 0))
                            {
                                User32.TranslateMessage(ref msg);
                                User32.DispatchMessage(ref msg);

                            }

                        }
                    }
                    else
                    {
                       
                        IntPtr hParent = GetRealParent(msg.hwnd);
                        //if(NativeWindow.TryGetWindow(hParent, out NativeWindow n))
                        //{
                        //    Debug.Print("TEST");
                        //}
                        if (hParent != IntPtr.Zero)
                        {

                            if ((User32.TranslateAccelerator(hParent, _mainWindow.Accelerators, ref msg) == 0) && (!User32.IsDialogMessage(hParent, ref msg)))
                            {
                                User32.TranslateMessage(ref msg);
                                User32.DispatchMessage(ref msg);

                            }


                        }
                        else
                        {
                            IntPtr hWndActive = User32.GetActiveWindow();
                            if(hWndActive != IntPtr.Zero)
                            {
                                if ((User32.TranslateAccelerator(hWndActive, _mainWindow.Accelerators, ref msg) == 0) && (!User32.IsDialogMessage(hWndActive, ref msg)))
                                {
                                    User32.TranslateMessage(ref msg);
                                    User32.DispatchMessage(ref msg);

                                }

                            }
                            else
                            {
                                if ((User32.TranslateAccelerator(_mainWindow.Handle, _mainWindow.Accelerators, ref msg) == 0) && (!User32.IsDialogMessage(_mainWindow.Handle, ref msg)))
                                {
                                    User32.TranslateMessage(ref msg);
                                    User32.DispatchMessage(ref msg);

                                }
                            }
                        }

                    }

                    //if (User32.TranslateAccelerator(_mainWindow.Handle, _mainWindow.Accelerators, ref msg) == 0)
                    //{

                    //        User32.TranslateMessage(ref msg);
                    //        User32.DispatchMessage(ref msg);


                    //}
                }
            }
        }
        private static void TaskAction()
        {
            Ole32.OleInitialize(IntPtr.Zero);
            while (_mainWindow.Handle != IntPtr.Zero)
            {
                try
                {
                    _mainWindow.Dispatch();
                }
                catch (Exception e)
                {
                    Debug.Print("Error in TaskAction=>" + e.Message);
                }
                
            }

            Ole32.OleUninitialize();
        }

        public static void DoEvents()
        {
            if (_mainWindow == null) return;
            while (User32.PeekMessage(out MSG msg, IntPtr.Zero, 0, 0, 0x0001 | 0x0002))
            {
                User32.TranslateMessage(ref msg);
                User32.DispatchMessage(ref msg);
            }
        }

    }
}