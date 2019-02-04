using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [ComConversionLoss]
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct MSG
  {
    [ComConversionLoss]
    public IntPtr hwnd;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.UINT")]
    public uint message;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.UINT_PTR")]
    public IntPtr wParam;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LONG_PTR")]
    public IntPtr lParam;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
    public uint time;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.POINT")]
    public POINT pt;
  }
}
