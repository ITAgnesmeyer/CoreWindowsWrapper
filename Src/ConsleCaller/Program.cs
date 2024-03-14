using CoreWindowsWrapper;
using System;

namespace ConsoleCaller
{
    class Program
    {
       [STAThread]
        public static int Main(string[] args)
        {
            BrowserWindow  nw = new BrowserWindow();
            NativeApp.Run(nw);
            return 0;
        }
    }
}
