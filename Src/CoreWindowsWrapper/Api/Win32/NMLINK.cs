using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class NmlInk
    {
        public NmHdr hdr = new NmHdr();
        public LItem item = new LItem();
    }
}