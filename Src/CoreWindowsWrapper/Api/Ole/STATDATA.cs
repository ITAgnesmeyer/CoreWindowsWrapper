using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct STATDATA
  {
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.FORMATETC")]
    public FORMATETC FORMATETC;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
    public uint ADVF;
    [MarshalAs(UnmanagedType.Interface)]
    public IAdviseSink pAdvSink;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
    public uint dwConnection;
  }
}
