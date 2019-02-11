using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_SYNTAX_IDENTIFIER
    {
        /// GUID->_GUID
        public GUID SyntaxGUID;

        /// RPC_VERSION->_RPC_VERSION
        public RPC_VERSION SyntaxVersion;
    }
}