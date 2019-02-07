using System;
using CoreWindowsWrapper;

namespace DIGAAppSetup
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
             MainForm nw = new MainForm();
            NativeApp.Run(nw);
        }
    }
}
