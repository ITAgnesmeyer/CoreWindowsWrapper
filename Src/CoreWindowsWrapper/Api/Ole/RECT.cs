using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct RECT
  {
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LONG")]
    public int left;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LONG")]
    public int top;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LONG")]
    public int right;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LONG")]
    public int bottom;
  }
}
