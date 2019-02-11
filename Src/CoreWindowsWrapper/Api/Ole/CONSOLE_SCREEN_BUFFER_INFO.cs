using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_SCREEN_BUFFER_INFO
    {
        /// COORD->_COORD
        public COORD dwSize;

        /// COORD->_COORD
        public COORD dwCursorPosition;

        /// WORD->unsigned short
        public ushort wAttributes;

        /// SMALL_RECT->_SMALL_RECT
        public SMALL_RECT srWindow;

        /// COORD->_COORD
        public COORD dwMaximumWindowSize;
    }
}