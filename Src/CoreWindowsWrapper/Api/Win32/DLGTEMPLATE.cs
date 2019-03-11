using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct DLGTEMPLATE {
    
        /// DWORD->unsigned int
        public uint style;
    
        /// DWORD->unsigned int
        public uint dwExtendedStyle;
    
        /// WORD->unsigned short
        public ushort cdit;
    
        /// short
        public short x;
    
        /// short
        public short y;
    
        /// short
        public short cx;
    
        /// short
        public short cy;
    }
}