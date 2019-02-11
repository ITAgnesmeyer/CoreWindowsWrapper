using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_CURSOR_INFO
    {
        /// DWORD->unsigned int
        public uint dwSize;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool bVisible;
    }
}