using CoreWindowsWrapper;
using System;

namespace ConsoleCaller
{
    class Program
    {
       [STAThread]
        public static int Main(string[] args)
        {
            ListViewTest nw = new ListViewTest();
            NativeApp.Run(nw);
            return 0;
        }
    }
}
