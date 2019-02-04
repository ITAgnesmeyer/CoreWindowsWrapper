using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [Guid("00000115-0000-0000-C000-000000000046")]
  [InterfaceType(1)]
  [ComImport]
  public interface IOleInPlaceUIWindow : IOleWindow
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void GetWindow(out IntPtr phwnd);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ContextSensitiveHelp([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fEnterMode);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetBorder([ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPRECT"), MarshalAs(UnmanagedType.LPArray), Out] RECT[] lprectBorder);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RequestBorderSpace([ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCBORDERWIDTHS"), MarshalAs(UnmanagedType.LPArray), In] RECT[] pborderwidths);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetBorderSpace([ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCBORDERWIDTHS"), MarshalAs(UnmanagedType.LPArray), In] RECT[] pborderwidths);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetActiveObject([MarshalAs(UnmanagedType.Interface), In] IOleInPlaceActiveObject pActiveObject, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR"), MarshalAs(UnmanagedType.LPWStr), In] string pszObjName);
  }
}
