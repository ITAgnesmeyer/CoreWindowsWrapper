using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FOCUS_EVENT_RECORD
    {
        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool bSetFocus;
    }
}