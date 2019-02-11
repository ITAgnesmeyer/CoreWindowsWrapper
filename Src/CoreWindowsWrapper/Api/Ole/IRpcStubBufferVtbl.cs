using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IRpcStubBufferVtbl
    {
        /// IRpcStubBufferVtbl_QueryInterface
        public IRpcStubBufferVtbl_QueryInterface AnonymousMember1;

        /// IRpcStubBufferVtbl_AddRef
        public IRpcStubBufferVtbl_AddRef AnonymousMember2;

        /// IRpcStubBufferVtbl_Release
        public IRpcStubBufferVtbl_Release AnonymousMember3;

        /// IRpcStubBufferVtbl_Connect
        public IRpcStubBufferVtbl_Connect AnonymousMember4;

        /// IRpcStubBufferVtbl_Disconnect
        public IRpcStubBufferVtbl_Disconnect AnonymousMember5;

        /// IRpcStubBufferVtbl_Invoke
        public IRpcStubBufferVtbl_Invoke AnonymousMember6;

        /// IRpcStubBufferVtbl_IsIIDSupported
        public IRpcStubBufferVtbl_IsIIDSupported AnonymousMember7;

        /// IRpcStubBufferVtbl_CountRefs
        public IRpcStubBufferVtbl_CountRefs AnonymousMember8;

        /// IRpcStubBufferVtbl_DebugServerQueryInterface
        public IRpcStubBufferVtbl_DebugServerQueryInterface AnonymousMember9;

        /// IRpcStubBufferVtbl_DebugServerRelease
        public IRpcStubBufferVtbl_DebugServerRelease AnonymousMember10;
    }
}