using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [ComConversionLoss]
  [StructLayout(LayoutKind.Sequential, Pack = 2)]
  public struct LOGPALETTE
  {
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.WORD")]
    public ushort palVersion;
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.WORD")]
    public ushort palNumEntries;
    [ComConversionLoss]
    [ComAliasName("Microsoft.VisualStudio.OLE.Interop.PALETTEENTRY")]
    public IntPtr palPalEntry;
  }
}
