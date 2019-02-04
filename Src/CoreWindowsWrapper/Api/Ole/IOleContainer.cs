using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [Guid("0000011B-0000-0000-C000-000000000046")]
  [InterfaceType(1)]
  [ComImport]
  public interface IOleContainer : IParseDisplayName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ParseDisplayName(
      [MarshalAs(UnmanagedType.Interface), In] IBindCtx pbc,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPOLESTR"), MarshalAs(UnmanagedType.LPWStr), In] string pszDisplayName,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] out uint pchEaten,
      [MarshalAs(UnmanagedType.Interface)] out IMoniker ppmkOut);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void EnumObjects([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint grfFlags, [MarshalAs(UnmanagedType.Interface)] out IEnumUnknown ppEnum);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void LockContainer([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fLock);
  }

}
