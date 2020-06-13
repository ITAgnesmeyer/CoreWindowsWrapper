using System.Runtime.InteropServices;

namespace Diga.Core.Api.Win32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class NmlInk
    {
        public NmHdr hdr = new NmHdr();
        public LItem item = new LItem();
    }
}