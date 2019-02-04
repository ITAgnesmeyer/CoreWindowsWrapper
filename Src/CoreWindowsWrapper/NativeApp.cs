using System;
using System.Threading.Tasks;

namespace CoreWindowsWrapper
{
    public static class NativeApp
    {
        private static NativeWindow _mainWindow;

        

        public static void Run(NativeWindow window)
        {
            _mainWindow = window;
            _mainWindow.IsMainWindow = true;
            _mainWindow.Show();
            Task t = new Task(TaskAction);
            t.RunSynchronously();
        }

        private static void TaskAction()
        {
            Api.Win32.Win32Api.OleInitialize(IntPtr.Zero);
            while (_mainWindow.Handle != IntPtr.Zero)
            {
                _mainWindow.Dispatch();
            }

            Api.Win32.Win32Api.OleUninitialize();
        }
    }
}