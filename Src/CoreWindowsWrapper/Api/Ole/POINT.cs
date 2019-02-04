using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct POINT
  {
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LONG")]
    public int x;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LONG")]
    public int y;
  }
}
