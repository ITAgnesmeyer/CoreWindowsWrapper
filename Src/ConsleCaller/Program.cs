using CoreWindowsWrapper;
using System;

namespace ConsleCaller
{
    class Program
    {
       
        public static int Main(string[] args)
        {
            Window1 nw = new Window1();
            NativeApp.Run(nw);
            return 0;
        }
    }
}
