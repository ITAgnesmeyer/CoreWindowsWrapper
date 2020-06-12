using CoreWindowsWrapper;
using System;

namespace ConsoleCaller
{
    class Program
    {
       [STAThread]
        public static int Main(string[] args)
        {
            Window4 nw = new Window4();
            NativeApp.Run(nw);
            return 0;
        }
    }
}
