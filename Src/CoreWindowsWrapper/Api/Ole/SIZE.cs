using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct SIZE
  {
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LONG")]
    public int cx;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LONG")]
    public int cy;
  }
}
