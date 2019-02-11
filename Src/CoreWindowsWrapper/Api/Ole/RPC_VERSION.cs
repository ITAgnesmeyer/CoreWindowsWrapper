using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_VERSION
    {
        /// unsigned short
        public ushort MajorVersion;

        /// unsigned short
        public ushort MinorVersion;
    }
}