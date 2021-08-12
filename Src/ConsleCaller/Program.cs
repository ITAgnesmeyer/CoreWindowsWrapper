using CoreWindowsWrapper;
using System;

namespace ConsoleCaller
{
    class Program
    {
       [STAThread]
        public static int Main(string[] args)
        {
            TestIpAddress nw = new TestIpAddress();
            NativeApp.Run(nw);
            return 0;
        }
    }
}
