using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [ComConversionLoss]
    [Guid("00000112-0000-0000-C000-000000000046")]
    [InterfaceType(1)]
    [ComImport]
    public interface IOleObject
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetClientSite([MarshalAs(UnmanagedType.Interface), In] IOleClientSite pClientSite);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetClientSite([MarshalAs(UnmanagedType.Interface)] out IOleClientSite ppClientSite);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetHostNames([ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR"), MarshalAs(UnmanagedType.LPWStr), In] string szContainerApp, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCOLESTR"), MarshalAs(UnmanagedType.LPWStr), In] string szContainerObj);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Close([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwSaveOption);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetMoniker([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwWhichMoniker, [MarshalAs(UnmanagedType.Interface), In] IMoniker pmk);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetMoniker([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwAssign, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwWhichMoniker, [MarshalAs(UnmanagedType.Interface)] out IMoniker ppmk);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int InitFromData([MarshalAs(UnmanagedType.Interface), In] IDataObject pDataObject, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fCreation, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwReserved);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetClipboardData([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwReserved, [MarshalAs(UnmanagedType.Interface)] out IDataObject ppDataObject);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int DoVerb(
          [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LONG"), In] int iVerb,
          [ComAliasName("Microsoft.VisualStudio.OLE.Interop.lpmsg"), MarshalAs(UnmanagedType.LPArray), In] MSG[] lpmsg,
          [MarshalAs(UnmanagedType.Interface), In] IOleClientSite pActiveSite,
          [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LONG"), In] int lindex,
          [In] IntPtr hWndParent,
          [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPCRECT"), MarshalAs(UnmanagedType.LPArray), In] RECT[] lprcPosRect);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int EnumVerbs([MarshalAs(UnmanagedType.Interface)] out IEnumOLEVERB ppEnumOleVerb);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int Update();

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int IsUpToDate();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetUserClassID(out Guid pClsid);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int GetUserType([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwFormOfType, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPOLESTR"), In] IntPtr pszUserType);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetExtent([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwDrawAspect, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.SIZEL"), MarshalAs(UnmanagedType.LPArray), In] SIZEL[] pSizel);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetExtent([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwDrawAspect, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.SIZEL"), MarshalAs(UnmanagedType.LPArray), Out] SIZEL[] pSizel);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Advise([MarshalAs(UnmanagedType.Interface), In] IAdviseSink pAdvSink, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")] out uint pdwConnection);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Unadvise([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwConnection);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumAdvise([MarshalAs(UnmanagedType.Interface)] out IEnumSTATDATA ppenumAdvise);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int GetMiscStatus([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwAspect, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")] out uint pdwStatus);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetColorScheme([ComAliasName("Microsoft.VisualStudio.OLE.Interop.LOGPALETTE"), MarshalAs(UnmanagedType.LPArray), In] LOGPALETTE[] pLogpal);
    }
}
