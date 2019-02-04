using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [InterfaceType(1)]
    [Guid("0000010E-0000-0000-C000-000000000046")]
    [ComImport]
    public interface IDataObject
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetData([ComAliasName("Microsoft.VisualStudio.OLE.Interop.FORMATETC"), MarshalAs(UnmanagedType.LPArray), In] FORMATETC[] pformatetcIn, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.STGMEDIUM"), MarshalAs(UnmanagedType.LPArray), Out] STGMEDIUM[] pRemoteMedium);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetDataHere([ComAliasName("Microsoft.VisualStudio.OLE.Interop.FORMATETC"), MarshalAs(UnmanagedType.LPArray), In] FORMATETC[] pFormatetc, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.STGMEDIUM"), MarshalAs(UnmanagedType.LPArray), In, Out] STGMEDIUM[] pRemoteMedium);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int QueryGetData([ComAliasName("Microsoft.VisualStudio.OLE.Interop.FORMATETC"), MarshalAs(UnmanagedType.LPArray), In] FORMATETC[] pFormatetc);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int GetCanonicalFormatEtc([ComAliasName("Microsoft.VisualStudio.OLE.Interop.FORMATETC"), MarshalAs(UnmanagedType.LPArray), In] FORMATETC[] pformatectIn, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.FORMATETC"), MarshalAs(UnmanagedType.LPArray), Out] FORMATETC[] pformatetcOut);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetData([ComAliasName("Microsoft.VisualStudio.OLE.Interop.FORMATETC"), MarshalAs(UnmanagedType.LPArray), In] FORMATETC[] pFormatetc, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.FLAG_STGMEDIUM"), MarshalAs(UnmanagedType.LPArray), In] STGMEDIUM[] pmedium, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fRelease);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int EnumFormatEtc([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwDirection, [MarshalAs(UnmanagedType.Interface)] out IEnumFORMATETC ppenumFormatEtc);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int DAdvise([ComAliasName("Microsoft.VisualStudio.OLE.Interop.FORMATETC"), MarshalAs(UnmanagedType.LPArray), In] FORMATETC[] pFormatetc, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint ADVF, [MarshalAs(UnmanagedType.Interface), In] IAdviseSink pAdvSink, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")] out uint pdwConnection);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void DUnadvise([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwConnection);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int EnumDAdvise([MarshalAs(UnmanagedType.Interface)] out IEnumSTATDATA ppenumAdvise);
    }
}
