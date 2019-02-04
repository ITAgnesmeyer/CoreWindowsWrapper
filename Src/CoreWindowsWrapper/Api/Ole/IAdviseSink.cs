using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [InterfaceType(1)]
    [Guid("0000010F-0000-0000-C000-000000000046")]
    [ComImport]
    public interface IAdviseSink
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void OnDataChange([ComAliasName("Microsoft.VisualStudio.OLE.Interop.FORMATETC"), MarshalAs(UnmanagedType.LPArray), In] FORMATETC[] pFormatetc, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.ASYNC_STGMEDIUM"), MarshalAs(UnmanagedType.LPArray), In] STGMEDIUM[] pStgmed);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void OnViewChange([ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD"), In] uint dwAspect, [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LONG"), In] int lindex);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void OnRename([MarshalAs(UnmanagedType.Interface), In] IMoniker pmk);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void OnSave();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void OnClose();
    }
}
