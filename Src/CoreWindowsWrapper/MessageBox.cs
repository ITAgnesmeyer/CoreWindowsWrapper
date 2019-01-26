using System;
using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    public static class MessageBox
    {

        public static MessageBoxResult Show(IntPtr parent, string message, string caption,MessageBoxOptions options = MessageBoxOptions.OkOnly )
        {
            return (MessageBoxResult)Win32Api.MessageBox(parent, message, caption, (uint) options);
        }

        public static MessageBoxResult Show(string message, string caption="API")
        {
            return Show(Win32Api.GetActiveWindow(), message, caption);
        }

       
    }
}
