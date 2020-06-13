using System.Runtime.InteropServices;

namespace Diga.Core.Api.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DlgTemplate 
    {
    
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