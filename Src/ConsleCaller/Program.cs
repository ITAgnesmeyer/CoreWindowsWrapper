using CoreWindowsWrapper;
using System;

namespace ConsoleCaller
{
    class Program
    {
       [STAThread]
        public static int Main(string[] args)
        {
            TextEditor nw = new TextEditor();
            NativeApp.Run(nw);
            return 0;
        }
    }
}
