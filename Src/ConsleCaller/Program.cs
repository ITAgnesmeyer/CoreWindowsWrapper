using CoreWindowsWrapper;
using System;

namespace ConsleCaller
{
    class Program
    {
       
        public static int Main(string[] args)
        {
            BrowserWindow nw = new BrowserWindow();
            NativeApp.Run(nw);
            return 0;
        }
    }
}
