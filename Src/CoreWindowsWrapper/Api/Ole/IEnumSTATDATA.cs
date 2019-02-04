using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [Guid("00000105-0000-0000-C000-000000000046")]
  [InterfaceType(1)]
  [ComImport]
  public interface IEnumSTATDATA
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int Next([ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG"), In] uint celt, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.STATDATA"), MarshalAs(UnmanagedType.LPArray), Out] STATDATA[] rgelt, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] out uint pceltFetched);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int Skip([ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG"), In] uint celt);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int Reset();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Clone([MarshalAs(UnmanagedType.Interface)] out IEnumSTATDATA ppEnum);
  }
}
