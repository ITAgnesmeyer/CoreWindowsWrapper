using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_FONT_INFO
    {
        /// DWORD->unsigned int
        public uint nFont;

        /// COORD->_COORD
        public COORD dwFontSize;
    }
}