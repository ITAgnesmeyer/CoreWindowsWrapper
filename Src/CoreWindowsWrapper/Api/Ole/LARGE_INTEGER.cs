using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct LARGE_INTEGER
  {
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LONGLONG")]
    public long QuadPart;
  }

}
