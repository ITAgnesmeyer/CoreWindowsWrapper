using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [ComConversionLoss]
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct FORMATETC
    {
        [ComAliasName("Microsoft.VisualStudio.OLE.Interop.CLIPFORMAT")]
        public ushort cfFormat;
        [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DVTARGETDEVICE")]
        [ComConversionLoss]
        public IntPtr ptd;
        [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
        public uint dwAspect;
        [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LONG")]
        public int lindex;
        [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
        public uint tymed;
    }
}
