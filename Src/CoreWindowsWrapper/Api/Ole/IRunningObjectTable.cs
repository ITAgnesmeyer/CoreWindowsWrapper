using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [InterfaceType(1)]
  [Guid("00000010-0000-0000-C000-000000000046")]
  [ComImport]
  public interface IRunningObjectTable
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Register([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint grfFlags, [MarshalAs(UnmanagedType.IUnknown), In] object punkObject, [MarshalAs(UnmanagedType.Interface), In] IMoniker pmkObjectName, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")] out uint pdwRegister);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Revoke([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwRegister);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int IsRunning([MarshalAs(UnmanagedType.Interface), In] IMoniker pmkObjectName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetObject([MarshalAs(UnmanagedType.Interface), In] IMoniker pmkObjectName, [MarshalAs(UnmanagedType.IUnknown)] out object ppunkObject);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NoteChangeTime([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwRegister, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.FILETIME"), MarshalAs(UnmanagedType.LPArray), In] FILETIME[] pFileTime);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetTimeOfLastChange([MarshalAs(UnmanagedType.Interface), In] IMoniker pmkObjectName, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.FILETIME"), MarshalAs(UnmanagedType.LPArray), Out] FILETIME[] pFileTime);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void EnumRunning([MarshalAs(UnmanagedType.Interface)] out IEnumMoniker ppenumMoniker);
  }

}
