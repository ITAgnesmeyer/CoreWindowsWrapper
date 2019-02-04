using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [InterfaceType(1)]
  [Guid("00000117-0000-0000-C000-000000000046")]
  [ComImport]
  public interface IOleInPlaceActiveObject : IOleWindow
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void GetWindow(out IntPtr phwnd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ContextSensitiveHelp([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fEnterMode);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int TranslateAccelerator([MarshalAs(UnmanagedType.LPArray), In] MSG[] lpmsg);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnFrameWindowActivate([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fActivate);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnDocWindowActivate([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fActivate);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ResizeBorder(
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCRECT"), MarshalAs(UnmanagedType.LPArray), In] RECT[] prcBorder,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.REFIID"), In] ref Guid riid,
      [MarshalAs(UnmanagedType.Interface), In] IOleInPlaceUIWindow pUIWindow,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fFrameWindow);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void EnableModeless([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fEnable);
  }
}
