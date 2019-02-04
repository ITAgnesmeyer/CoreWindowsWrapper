using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [InterfaceType(1)]
    [ComConversionLoss]
    [Guid("00000116-0000-0000-C000-000000000046")]
    [ComImport]
    public interface IOleInPlaceFrame : IOleInPlaceUIWindow
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetWindow(out IntPtr phwnd);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void ContextSensitiveHelp([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fEnterMode);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void GetBorder([ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPRECT"), MarshalAs(UnmanagedType.LPArray), Out] RECT[] lprectBorder);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void RequestBorderSpace([ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCBORDERWIDTHS"), MarshalAs(UnmanagedType.LPArray), In] RECT[] pborderwidths);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void SetBorderSpace([ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCBORDERWIDTHS"), MarshalAs(UnmanagedType.LPArray), In] RECT[] pborderwidths);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        new void SetActiveObject([MarshalAs(UnmanagedType.Interface), In] IOleInPlaceActiveObject pActiveObject, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR"), MarshalAs(UnmanagedType.LPWStr), In] string pszObjName);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void InsertMenus([In] IntPtr hmenuShared, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.OLEMENUGROUPWIDTHS"), MarshalAs(UnmanagedType.LPArray), In, Out] OLEMENUGROUPWIDTHS[] lpMenuWidths);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetMenu([In] IntPtr hmenuShared, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.HOLEMENU"), In] IntPtr HOLEMENU, [In] IntPtr hwndActiveObject);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RemoveMenus([In] IntPtr hmenuShared);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetStatusText([ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR"), MarshalAs(UnmanagedType.LPWStr), In] string pszStatusText);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnableModeless([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fEnable);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int TranslateAccelerator([ComAliasName("Microsoft.VisualStudio.OLE.Interop.MSG"), MarshalAs(UnmanagedType.LPArray), In] MSG[] lpmsg, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.WORD"), In] ushort wID);
    }
}
