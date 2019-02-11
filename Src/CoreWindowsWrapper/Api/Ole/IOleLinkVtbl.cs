using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleLinkVtbl
    {
        /// IOleLinkVtbl_QueryInterface
        public IOleLinkVtbl_QueryInterface AnonymousMember1;

        /// IOleLinkVtbl_AddRef
        public IOleLinkVtbl_AddRef AnonymousMember2;

        /// IOleLinkVtbl_Release
        public IOleLinkVtbl_Release AnonymousMember3;

        /// IOleLinkVtbl_SetUpdateOptions
        public IOleLinkVtbl_SetUpdateOptions AnonymousMember4;

        /// IOleLinkVtbl_GetUpdateOptions
        public IOleLinkVtbl_GetUpdateOptions AnonymousMember5;

        /// IOleLinkVtbl_SetSourceMoniker
        public IOleLinkVtbl_SetSourceMoniker AnonymousMember6;

        /// IOleLinkVtbl_GetSourceMoniker
        public IOleLinkVtbl_GetSourceMoniker AnonymousMember7;

        /// IOleLinkVtbl_SetSourceDisplayName
        public IOleLinkVtbl_SetSourceDisplayName AnonymousMember8;

        /// IOleLinkVtbl_GetSourceDisplayName
        public IOleLinkVtbl_GetSourceDisplayName AnonymousMember9;

        /// IOleLinkVtbl_BindToSource
        public IOleLinkVtbl_BindToSource AnonymousMember10;

        /// IOleLinkVtbl_BindIfRunning
        public IOleLinkVtbl_BindIfRunning AnonymousMember11;

        /// IOleLinkVtbl_GetBoundSource
        public IOleLinkVtbl_GetBoundSource AnonymousMember12;

        /// IOleLinkVtbl_UnbindSource
        public IOleLinkVtbl_UnbindSource AnonymousMember13;

        /// IOleLinkVtbl_Update
        public IOleLinkVtbl_Update AnonymousMember14;
    }
}