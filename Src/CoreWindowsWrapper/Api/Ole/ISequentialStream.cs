using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [Guid("0C733A30-2A1C-11CE-ADE5-00AA0044773D")]
  [InterfaceType(1)]
  [ComImport]
  public interface ISequentialStream
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Read([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1), Out] byte[] pv, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG"), In] uint cb, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] out uint pcbRead);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Write([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1), In] byte[] pv, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG"), In] uint cb, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] out uint pcbWritten);
  }

}
