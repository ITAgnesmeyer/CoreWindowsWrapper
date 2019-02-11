using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_SELECTION_INFO
    {
        /// DWORD->unsigned int
        public uint dwFlags;

        /// COORD->_COORD
        public COORD dwSelectionAnchor;

        /// SMALL_RECT->_SMALL_RECT
        public SMALL_RECT srSelection;
    }
}