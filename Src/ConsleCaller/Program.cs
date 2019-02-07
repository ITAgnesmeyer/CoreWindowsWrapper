using CoreWindowsWrapper;
using System;

namespace ConsleCaller
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Window1 nw = new Window1();
            NativeApp.Run(nw);
        }
    }
}
