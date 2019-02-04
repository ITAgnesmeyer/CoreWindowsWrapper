using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct OLEVERB
  {
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LONG")]
    public int lVerb;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPOLESTR")]
    [MarshalAs(UnmanagedType.LPWStr)]
    public string lpszVerbName;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
    public uint fuFlags;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
    public uint grfAttribs;
  }
}
