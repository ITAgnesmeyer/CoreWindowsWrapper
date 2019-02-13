using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    public class NMLINK
    {
        public NMHDR hdr = new NMHDR();
        public LITEM item = new LITEM();
    }
}