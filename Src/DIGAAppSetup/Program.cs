using System;
using CoreWindowsWrapper;

namespace DIGAAppSetup
{
    class Program
    {
        static void Main(string[] args)
        {
             MainForm nw = new MainForm();
            NativeApp.Run(nw);
        }
    }
}
