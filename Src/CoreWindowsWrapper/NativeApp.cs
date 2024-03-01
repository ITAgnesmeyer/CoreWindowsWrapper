using System;
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

            _mainWindow = window;
            _mainWindow.IsMainWindow = true;
            _mainWindow.Show();

            //Task t = new Task(TaskAction);
            //t.RunSynchronously();
            Dispatch();
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

                    if ((User32.TranslateAccelerator(_mainWindow.Handle, _mainWindow.Accelerators, ref msg) == 0) && (!User32.IsDialogMessage(_mainWindow.Handle, ref msg)))
                    {
                                User32.TranslateMessage(ref msg);
                                User32.DispatchMessage(ref msg);

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