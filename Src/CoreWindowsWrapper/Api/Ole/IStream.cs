using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [Guid("0000000C-0000-0000-C000-000000000046")]
  [InterfaceType(1)]
  [ComImport]
  public interface IStream : ISequentialStream
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void Read([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1), Out] byte[] pv, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG"), In] uint cb, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] out uint pcbRead);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void Write([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1), In] byte[] pv, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG"), In] uint cb, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] out uint pcbWritten);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Seek([ComAliasName("Microsoft.VisualStudio.OLE.Interop.LARGE_INTEGER"), In] LARGE_INTEGER dlibMove, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwOrigin, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER"), MarshalAs(UnmanagedType.LPArray), Out] ULARGE_INTEGER[] plibNewPosition);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetSize([ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER"), In] ULARGE_INTEGER libNewSize);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CopyTo(
      [MarshalAs(UnmanagedType.Interface), In] IStream pstm,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER"), In] ULARGE_INTEGER cb,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER"), MarshalAs(UnmanagedType.LPArray), Out] ULARGE_INTEGER[] pcbRead,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER"), MarshalAs(UnmanagedType.LPArray), Out] ULARGE_INTEGER[] pcbWritten);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Commit([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint grfCommitFlags);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Revert();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void LockRegion([ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER"), In] ULARGE_INTEGER libOffset, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER"), In] ULARGE_INTEGER cb, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwLockType);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void UnlockRegion([ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER"), In] ULARGE_INTEGER libOffset, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER"), In] ULARGE_INTEGER cb, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwLockType);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Stat([ComAliasName("Microsoft.VisualStudio.OLE.Interop.STATSTG"), MarshalAs(UnmanagedType.LPArray), Out] STATSTG[] pstatstg, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint grfStatFlag);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Clone([MarshalAs(UnmanagedType.Interface)] out IStream ppstm);
  }

}
