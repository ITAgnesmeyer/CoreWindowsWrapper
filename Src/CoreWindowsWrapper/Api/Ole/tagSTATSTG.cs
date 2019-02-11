using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSTATSTG
    {
        /// LPOLESTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwcsName;

        /// DWORD->unsigned int
        public uint type;

        /// ULARGE_INTEGER->_ULARGE_INTEGER
        public ULARGE_INTEGER cbSize;

        /// FILETIME->_FILETIME
        public FILETIME mtime;

        /// FILETIME->_FILETIME
        public FILETIME ctime;

        /// FILETIME->_FILETIME
        public FILETIME atime;

        /// DWORD->unsigned int
        public uint grfMode;

        /// DWORD->unsigned int
        public uint grfLocksSupported;

        /// CLSID->GUID->_GUID
        public GUID clsid;

        /// DWORD->unsigned int
        public uint grfStateBits;

        /// DWORD->unsigned int
        public uint reserved;
    }
}