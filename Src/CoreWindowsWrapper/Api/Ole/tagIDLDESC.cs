using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagIDLDESC
    {
        /// ULONG_PTR->unsigned int
        public uint dwReserved;

        /// USHORT->unsigned short
        public ushort wIDLFlags;
    }
}