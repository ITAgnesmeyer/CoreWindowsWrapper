using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSIZE
    {
        /// LONG->int
        public int cx;

        /// LONG->int
        public int cy;
    }
}