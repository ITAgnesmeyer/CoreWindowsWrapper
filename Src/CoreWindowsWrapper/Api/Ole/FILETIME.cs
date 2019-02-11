using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FILETIME
    {
        /// DWORD->unsigned int
        public uint dwLowDateTime;

        /// DWORD->unsigned int
        public uint dwHighDateTime;
    }
}