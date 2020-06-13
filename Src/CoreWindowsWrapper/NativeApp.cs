using System;
using System.Diagnostics;
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
    }
}