using System;

using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public static class MessageBox
    {

        public static MessageBoxResult Show(IntPtr parent, string message, string caption,MessageBoxOptions options = MessageBoxOptions.OkOnly )
        {
            return (MessageBoxResult)User32.MessageBox(parent, message, caption, (uint) options);
        }

        public static MessageBoxResult Show(string message, string caption="API")
        {
            return Show(User32.GetActiveWindow(), message, caption);
        }

       
    }
}
