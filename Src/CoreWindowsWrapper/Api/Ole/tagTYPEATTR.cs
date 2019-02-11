using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagTYPEATTR
    {
        /// GUID->_GUID
        public GUID guid;

        /// LCID->DWORD->unsigned int
        public uint lcid;

        /// DWORD->unsigned int
        public uint dwReserved;

        /// MEMBERID->DISPID->LONG->int
        public int memidConstructor;

        /// MEMBERID->DISPID->LONG->int
        public int memidDestructor;

        /// LPOLESTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrSchema;

        /// ULONG->unsigned int
        public uint cbSizeInstance;

        /// TYPEKIND->tagTYPEKIND
        public tagTYPEKIND typekind;

        /// WORD->unsigned short
        public ushort cFuncs;

        /// WORD->unsigned short
        public ushort cVars;

        /// WORD->unsigned short
        public ushort cImplTypes;

        /// WORD->unsigned short
        public ushort cbSizeVft;

        /// WORD->unsigned short
        public ushort cbAlignment;

        /// WORD->unsigned short
        public ushort wTypeFlags;

        /// WORD->unsigned short
        public ushort wMajorVerNum;

        /// WORD->unsigned short
        public ushort wMinorVerNum;

        /// TYPEDESC->tagTYPEDESC
        public tagTYPEDESC tdescAlias;

        /// IDLDESC->tagIDLDESC
        public tagIDLDESC idldescType;
    }
}