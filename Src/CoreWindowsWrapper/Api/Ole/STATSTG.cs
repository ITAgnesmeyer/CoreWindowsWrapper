using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct STATSTG
  {
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPOLESTR")]
    [MarshalAs(UnmanagedType.LPWStr)]
    public string pwcsName;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
    public uint type;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER")]
    public ULARGE_INTEGER cbSize;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.FILETIME")]
    public FILETIME mtime;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.FILETIME")]
    public FILETIME ctime;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.FILETIME")]
    public FILETIME atime;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
    public uint grfMode;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
    public uint grfLocksSupported;
    public Guid clsid;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
    public uint grfStateBits;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
    public uint reserved;
  }

}
