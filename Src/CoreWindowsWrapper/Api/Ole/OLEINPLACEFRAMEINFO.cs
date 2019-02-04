using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [ComConversionLoss]
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct OLEINPLACEFRAMEINFO
  {
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.UINT")]
    public uint cb;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.BOOL")]
    public int fMDIApp;
    [ComConversionLoss]
    public IntPtr hwndFrame;
    [ComConversionLoss]
    public IntPtr haccel;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.UINT")]
    public uint cAccelEntries;
  }
}
