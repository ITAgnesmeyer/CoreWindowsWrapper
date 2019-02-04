using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct STGMEDIUM
  {
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
    public uint tymed;
    public IntPtr unionmember;
    [MarshalAs(UnmanagedType.IUnknown)]
    public object pUnkForRelease;
  }
}
