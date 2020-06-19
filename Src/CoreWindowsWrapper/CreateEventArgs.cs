using Diga.Core.Api.Win32;
using System;

namespace CoreWindowsWrapper
{
    public class EventArgStyleWrapper
    {
        public uint Style { get; set; }
        public uint StyleEx { get; set; }
        public EventArgStyleWrapper(uint style, uint styleEx)
        {
            this.Style = style;
            this.StyleEx = styleEx;
        }
    }
    [Serializable]
    public class BeforeWindowCreateEventArgs: EventArgs
    {
        
        
        public EventArgStyleWrapper Styles { get; set; }
        public BeforeWindowCreateEventArgs(uint style, uint styleEx)
        {
            this.Styles = new EventArgStyleWrapper(style, styleEx);
        }
    }

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