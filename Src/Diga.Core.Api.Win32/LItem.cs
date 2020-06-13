using System.Runtime.InteropServices;

namespace Diga.Core.Api.Win32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class LItem
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