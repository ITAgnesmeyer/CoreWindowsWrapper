using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [Guid("00000122-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface IOleDropTarget
    {
      [MethodImpl(MethodImplOptions.PreserveSig)]
      int OleDragEnter(
        [MarshalAs(UnmanagedType.Interface), In] object pDataObj,
        [MarshalAs(UnmanagedType.U4), In] int grfKeyState,
        [In] POINT pt,
        [In, Out] ref int pdwEffect);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      int OleDragOver([MarshalAs(UnmanagedType.U4), In] int grfKeyState, [In] POINT pt, [In, Out] ref int pdwEffect);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      int OleDragLeave();

      [MethodImpl(MethodImplOptions.PreserveSig)]
      int OleDrop(
        [MarshalAs(UnmanagedType.Interface), In] object pDataObj,
        [MarshalAs(UnmanagedType.U4), In] int grfKeyState,
        [In] POINT pt,
        [In, Out] ref int pdwEffect);
    }

}
