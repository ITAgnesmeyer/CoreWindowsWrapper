using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [InterfaceType(1)]
  [Guid("00000102-0000-0000-C000-000000000046")]
  [ComImport]
  public interface IEnumMoniker
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int Next([ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG"), In] uint celt, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface), Out] IMoniker[] rgelt, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] out uint pceltFetched);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int Skip([ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG"), In] uint celt);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int Reset();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Clone([MarshalAs(UnmanagedType.Interface)] out IEnumMoniker ppEnum);
  }

}
