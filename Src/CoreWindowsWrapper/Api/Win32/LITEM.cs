using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public class LITEM
    {
        public uint mask;
        public int iLink;
        public uint state;
        public uint stateMask;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
        public string szID;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2083)]
        public string szUrl;

    }
}