using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        /// LONG->int
        public int x;

        /// LONG->int
        public int y;
    }
}