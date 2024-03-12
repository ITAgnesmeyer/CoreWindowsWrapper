using CoreWindowsWrapper;
using System;

namespace ConsoleCaller
{
    class Program
    {
       [STAThread]
        public static int Main(string[] args)
        {
            Window1  nw = new Window1();
            NativeApp.Run(nw);
            return 0;
        }
    }
}
