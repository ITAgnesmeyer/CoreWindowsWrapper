using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct HighLow
    {
        public int iLow;
        public int iHigh;
    }
}