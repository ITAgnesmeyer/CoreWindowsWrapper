using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [Guid("00000104-0000-0000-C000-000000000046")]
  [InterfaceType(1)]
  [ComImport]
  public interface IEnumOLEVERB
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int Next([ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG"), In] uint celt, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.OLEVERB"), MarshalAs(UnmanagedType.LPArray), Out] OLEVERB[] rgelt, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] out uint pceltFetched);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int Skip([ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG"), In] uint celt);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int Reset();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Clone([MarshalAs(UnmanagedType.Interface)] out IEnumOLEVERB ppEnum);
  }
}
