using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [ComVisible(true)]
    [Guid("B722BCCB-4E68-101B-A2BC-00AA00404770")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface IOleCommandTarget
    {
      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int QueryStatus(
        ref Guid pguidCmdGroup,
        int cCmds,
        [In, Out] OLECMD prgCmds,
        [In, Out] IntPtr pCmdText);

      [MethodImpl(MethodImplOptions.PreserveSig)]
      [return: MarshalAs(UnmanagedType.I4)]
      int Exec(ref Guid pguidCmdGroup, int nCmdID, int nCmdexecopt, [MarshalAs(UnmanagedType.LPArray), In] object[] pvaIn, int pvaOut);
    }

}
