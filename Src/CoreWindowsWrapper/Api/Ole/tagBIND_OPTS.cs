using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagBIND_OPTS
    {
        /// DWORD->unsigned int
        public uint cbStruct;

        /// DWORD->unsigned int
        public uint grfFlags;

        /// DWORD->unsigned int
        public uint grfMode;

        /// DWORD->unsigned int
        public uint dwTickCountDeadline;
    }
}