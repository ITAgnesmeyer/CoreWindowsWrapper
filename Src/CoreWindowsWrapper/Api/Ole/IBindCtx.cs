using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [Guid("0000000E-0000-0000-C000-000000000046")]
    [InterfaceType(1)]
    [ComImport]
    public interface IBindCtx
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RegisterObjectBound([MarshalAs(UnmanagedType.IUnknown), In] object punk);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RevokeObjectBound([MarshalAs(UnmanagedType.IUnknown), In] object punk);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ReleaseBoundObjects();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void SetBindOptions([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BIND_OPTS2"), MarshalAs(UnmanagedType.LPArray), In] BIND_OPTS2[] pbindopts);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetBindOptions([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BIND_OPTS2"), MarshalAs(UnmanagedType.LPArray), In, Out] BIND_OPTS2[] pbindopts);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetRunningObjectTable([MarshalAs(UnmanagedType.Interface)] out IRunningObjectTable pprot);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RegisterObjectParam([ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPOLESTR"), MarshalAs(UnmanagedType.LPWStr), In] string pszKey, [MarshalAs(UnmanagedType.IUnknown), In] object punk);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetObjectParam([ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPOLESTR"), MarshalAs(UnmanagedType.LPWStr), In] string pszKey, [MarshalAs(UnmanagedType.IUnknown)] out object ppunk);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void EnumObjectParam([MarshalAs(UnmanagedType.Interface)] out IEnumString ppEnum);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RevokeObjectParam([ComAliasName("Microsoft.VisualStudio.OLE.Interop.LPOLESTR"), MarshalAs(UnmanagedType.LPWStr), In] string pszKey);
    }

}
