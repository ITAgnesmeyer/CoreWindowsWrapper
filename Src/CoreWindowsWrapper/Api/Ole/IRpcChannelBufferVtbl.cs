using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IRpcChannelBufferVtbl
    {
        /// IRpcChannelBufferVtbl_QueryInterface
        public IRpcChannelBufferVtbl_QueryInterface AnonymousMember1;

        /// IRpcChannelBufferVtbl_AddRef
        public IRpcChannelBufferVtbl_AddRef AnonymousMember2;

        /// IRpcChannelBufferVtbl_Release
        public IRpcChannelBufferVtbl_Release AnonymousMember3;

        /// IRpcChannelBufferVtbl_GetBuffer
        public IRpcChannelBufferVtbl_GetBuffer AnonymousMember4;

        /// IRpcChannelBufferVtbl_SendReceive
        public IRpcChannelBufferVtbl_SendReceive AnonymousMember5;

        /// IRpcChannelBufferVtbl_FreeBuffer
        public IRpcChannelBufferVtbl_FreeBuffer AnonymousMember6;

        /// IRpcChannelBufferVtbl_GetDestCtx
        public IRpcChannelBufferVtbl_GetDestCtx AnonymousMember7;

        /// IRpcChannelBufferVtbl_IsConnected
        public IRpcChannelBufferVtbl_IsConnected AnonymousMember8;
    }
}