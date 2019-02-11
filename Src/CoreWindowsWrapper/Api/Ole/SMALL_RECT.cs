using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SMALL_RECT
    {
        /// SHORT->short
        public short Left;

        /// SHORT->short
        public short Top;

        /// SHORT->short
        public short Right;

        /// SHORT->short
        public short Bottom;
    }
}