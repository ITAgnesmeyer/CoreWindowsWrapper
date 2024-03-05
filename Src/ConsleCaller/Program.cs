using CoreWindowsWrapper;
using System;

namespace ConsoleCaller
{
    class Program
    {
       [STAThread]
        public static int Main(string[] args)
        {
            ControlOnControl nw = new ControlOnControl();
            NativeApp.Run(nw);
            return 0;
        }
    }
}
