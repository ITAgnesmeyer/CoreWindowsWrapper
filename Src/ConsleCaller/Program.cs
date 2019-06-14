using CoreWindowsWrapper;
using System;

namespace ConsleCaller
{
    class Program
    {
       
        public static int Main(string[] args)
        {
            Windows3 nw = new Windows3();
            NativeApp.Run(nw);
            return 0;
        }
    }
}
