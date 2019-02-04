using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct FILETIME
    {
        [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
        public uint dwLowDateTime;
        [ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")]
        public uint dwHighDateTime;
    }

}
