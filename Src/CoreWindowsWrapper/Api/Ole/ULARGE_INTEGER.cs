using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct ULARGE_INTEGER
  {
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONGLONG")]
    public ulong QuadPart;
  }

}
