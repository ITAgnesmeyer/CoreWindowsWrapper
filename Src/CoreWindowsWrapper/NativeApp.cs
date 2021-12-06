using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Diga.Core.Api.Win32;
namespace CoreWindowsWrapper
{
    public static class NativeApp
    {
        private static NativeWindow _mainWindow;

        

        public static void Run(NativeWindow window)
        {
            //Api.Win32.Win32Api.EnableVisualStyles();
            
            _mainWindow = window;
            _mainWindow.IsMainWindow = true;
            _mainWindow.Show();
            
            Task t = new Task(TaskAction);
            t.RunSynchronously();
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