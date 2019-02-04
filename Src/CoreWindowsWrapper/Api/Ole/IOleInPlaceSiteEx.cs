using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{

    [Guid("9C2CAD80-3424-11CF-B670-00AA004CD6D8")]
  [InterfaceType(1)]
  [ComImport]
  public interface IOleInPlaceSiteEx : IOleInPlaceSite
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void GetWindow(out IntPtr phwnd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ContextSensitiveHelp([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fEnterMode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void CanInPlaceActivate();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void OnInPlaceActivate();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void OnUIActivate();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void GetWindowContext(
      [MarshalAs(UnmanagedType.Interface)] out IOleInPlaceFrame ppFrame,
      [MarshalAs(UnmanagedType.Interface)] out IOleInPlaceUIWindow ppDoc,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPRECT"), MarshalAs(UnmanagedType.LPArray), Out] RECT[] lprcPosRect,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPRECT"), MarshalAs(UnmanagedType.LPArray), Out] RECT[] lprcClipRect,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.OLEINPLACEFRAMEINFO"), MarshalAs(UnmanagedType.LPArray), In, Out] OLEINPLACEFRAMEINFO[] lpFrameInfo);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void Scroll([ComAliasName("Microsoft.VisualStudio.OLE.Interop.SIZE"), In] SIZE scrollExtant);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void OnUIDeactivate([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fUndoable);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void OnInPlaceDeactivate();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void DiscardUndoState();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void DeactivateAndUndo();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void OnPosRectChange([ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCRECT"), MarshalAs(UnmanagedType.LPArray), In] RECT[] lprcPosRect);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnInPlaceActivateEx([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL")] out int pfNoRedraw, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwFlags);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnInPlaceDeactivateEx([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fNoRedraw);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int RequestUIActivate();
  }
}
