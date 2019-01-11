using System;

namespace CoreWindowsWrapper.Win32ApiForm
{
    [Serializable]
    public class CreateEventArgs: EventArgs
    {
        public IntPtr Handle { get; }

        public CreateEventArgs(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}