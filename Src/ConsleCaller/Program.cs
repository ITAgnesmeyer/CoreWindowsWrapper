using CoreWindowsWrapper;
using System;

namespace ConsoleCaller
{
    class Program
    {
       [STAThread]
        public static int Main(string[] args)
        {
            TreeViewTest nw = new TreeViewTest();
            NativeApp.Run(nw);
            return 0;
        }
    }
}
