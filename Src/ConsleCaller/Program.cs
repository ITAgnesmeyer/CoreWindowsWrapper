using CoreWindowsWrapper;
using System;

namespace ConsoleCaller
{
    class Program
    {
       [STAThread]
        public static int Main(string[] args)
        {
            NativeApp.ExceptInEvents = true;
            TextEditor   nw = new TextEditor();
            NativeApp.Run(nw);
            return 0;
        }
    }
}
