using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [InterfaceType(1)]
  [Guid("0000011A-0000-0000-C000-000000000046")]
  [ComImport]
  public interface IParseDisplayName
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ParseDisplayName(
      [MarshalAs(UnmanagedType.Interface), In] IBindCtx pbc,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPOLESTR"), MarshalAs(UnmanagedType.LPWStr), In] string pszDisplayName,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] out uint pchEaten,
      [MarshalAs(UnmanagedType.Interface)] out IMoniker ppmkOut);
  }

}
