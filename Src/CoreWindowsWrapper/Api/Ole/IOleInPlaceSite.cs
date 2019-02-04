using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [Guid("00000119-0000-0000-C000-000000000046")]
  [InterfaceType(1)]
  [ComImport]
  public interface IOleInPlaceSite : IOleWindow
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void GetWindow(out IntPtr phwnd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ContextSensitiveHelp([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fEnterMode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void CanInPlaceActivate();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnInPlaceActivate();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnUIActivate();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetWindowContext(
      [MarshalAs(UnmanagedType.Interface)] out IOleInPlaceFrame ppFrame,
      [MarshalAs(UnmanagedType.Interface)] out IOleInPlaceUIWindow ppDoc,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPRECT"), MarshalAs(UnmanagedType.LPArray), Out] RECT[] lprcPosRect,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPRECT"), MarshalAs(UnmanagedType.LPArray), Out] RECT[] lprcClipRect,
      [ComAliasName("Microsoft.VisualStudio.OLE.Interop.OLEINPLACEFRAMEINFO"), MarshalAs(UnmanagedType.LPArray), In, Out] OLEINPLACEFRAMEINFO[] lpFrameInfo);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Scroll([ComAliasName("Microsoft.VisualStudio.OLE.Interop.SIZE"), In] SIZE scrollExtant);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnUIDeactivate([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fUndoable);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnInPlaceDeactivate();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DiscardUndoState();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeactivateAndUndo();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnPosRectChange([ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCRECT"), MarshalAs(UnmanagedType.LPArray), In] RECT[] lprcPosRect);
  }
}
