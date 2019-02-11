using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_MESSAGE
    {
        /// RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        public IntPtr Handle;

        /// unsigned int
        public uint DataRepresentation;

        /// void*
        public IntPtr Buffer;

        /// unsigned int
        public uint BufferLength;

        /// unsigned int
        public uint ProcNum;

        /// PRPC_SYNTAX_IDENTIFIER->_RPC_SYNTAX_IDENTIFIER*
        public IntPtr TransferSyntax;

        /// void*
        public IntPtr RpcInterfaceInformation;

        /// void*
        public IntPtr ReservedForRuntime;

        /// void*
        public IntPtr ManagerEpv;

        /// void*
        public IntPtr ImportContext;

        /// unsigned int
        public uint RpcFlags;
    }
}