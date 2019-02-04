using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [ComConversionLoss]
    [Guid("00000114-0000-0000-C000-000000000046")]
    [InterfaceType(1)]
    [ComImport]
    public interface IOleWindow
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void GetWindow(out IntPtr phwnd);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ContextSensitiveHelp([ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL"), In] int fEnterMode);
    }
}
