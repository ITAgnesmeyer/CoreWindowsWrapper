using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [ComConversionLoss]
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct BIND_OPTS2
    {
        [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
        public uint cbStruct;
        [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
        public uint grfFlags;
        [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
        public uint grfMode;
        [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
        public uint dwTickCountDeadline;
        [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
        public uint dwTrackFlags;
        [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
        public uint dwClassContext;
        [ComAliasName("Microsoft.VisualStudio.OLE.Interop.LCID")]
        public uint locale;
        [ComConversionLoss]
        [ComAliasName("Microsoft.VisualStudio.OLE.Interop.COSERVERINFO")]
        public IntPtr pServerInfo;
    }

}
