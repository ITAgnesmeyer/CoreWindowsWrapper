using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [InterfaceType(1)]
  [Guid("00000118-0000-0000-C000-000000000046")]
  [ComImport]
  public interface IOleClientSite
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SaveObject();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetMoniker([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwAssign, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwWhichMoniker, [MarshalAs(UnmanagedType.Interface)] out IMoniker ppmk);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetContainer([MarshalAs(UnmanagedType.Interface)] out IOleContainer ppContainer);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ShowObject();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnShowWindow([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fShow);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RequestNewObjectLayout();
  }
}
