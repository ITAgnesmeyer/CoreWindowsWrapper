using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential,
        CharSet = CharSet.Ansi)]
    public struct GUID
    {
        /// unsigned int
        public uint Data1;

        /// unsigned short
        public ushort Data2;

        /// unsigned short
        public ushort Data3;

        /// unsigned char[8]
        [MarshalAs(UnmanagedType.ByValTStr,
            SizeConst = 8)]
        public string Data4;
        

        public GUID(GUID riid) : this()
        {
            this.Data1 = riid.Data1;
            this.Data2 = riid.Data2;
            this.Data3 = riid.Data3;
            this.Data4 = riid.Data4;
        }
    }
}