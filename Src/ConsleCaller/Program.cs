using CoreWindowsWrapper;
using System;

namespace ConsleCaller
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Windows3 nw = new Windows3();
            NativeApp.Run(nw);
        }
    }
}
