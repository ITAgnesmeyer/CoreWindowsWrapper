using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagTLIBATTR
    {
        /// GUID->_GUID
        public GUID guid;

        /// LCID->DWORD->unsigned int
        public uint lcid;

        /// SYSKIND->tagSYSKIND
        public tagSYSKIND syskind;

        /// WORD->unsigned short
        public ushort wMajorVerNum;

        /// WORD->unsigned short
        public ushort wMinorVerNum;

        /// WORD->unsigned short
        public ushort wLibFlags;
    }
}