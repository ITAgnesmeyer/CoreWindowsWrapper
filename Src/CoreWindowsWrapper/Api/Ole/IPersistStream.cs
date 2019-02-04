using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [Guid("00000109-0000-0000-C000-000000000046")]
  [InterfaceType(1)]
  [ComImport]
  public interface IPersistStream : IPersist
  {
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int GetClassID(out Guid pClassID);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int IsDirty();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Load([MarshalAs(UnmanagedType.Interface), In] IStream pstm);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Save([MarshalAs(UnmanagedType.Interface), In] IStream pstm, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fClearDirty);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetSizeMax([ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER"), MarshalAs(UnmanagedType.LPArray), Out] ULARGE_INTEGER[] pcbSize);
  }

}
