using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MOUSE_EVENT_RECORD
    {
        /// COORD->_COORD
        public COORD dwMousePosition;

        /// DWORD->unsigned int
        public uint dwButtonState;

        /// DWORD->unsigned int
        public uint dwControlKeyState;

        /// DWORD->unsigned int
        public uint dwEventFlags;
    }
}