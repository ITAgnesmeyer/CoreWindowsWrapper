using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct COORD
    {
        /// SHORT->short
        public short X;

        /// SHORT->short
        public short Y;
    }
}