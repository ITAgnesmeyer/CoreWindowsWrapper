using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleContainerVtbl
    {
        /// IOleContainerVtbl_QueryInterface
        public IOleContainerVtbl_QueryInterface AnonymousMember1;

        /// IOleContainerVtbl_AddRef
        public IOleContainerVtbl_AddRef AnonymousMember2;

        /// IOleContainerVtbl_Release
        public IOleContainerVtbl_Release AnonymousMember3;

        /// IOleContainerVtbl_ParseDisplayName
        public IOleContainerVtbl_ParseDisplayName AnonymousMember4;

        /// IOleContainerVtbl_EnumObjects
        public IOleContainerVtbl_EnumObjects AnonymousMember5;

        /// IOleContainerVtbl_LockContainer
        public IOleContainerVtbl_LockContainer AnonymousMember6;
    }
}