using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleItemContainerVtbl
    {
        /// IOleItemContainerVtbl_QueryInterface
        public IOleItemContainerVtbl_QueryInterface AnonymousMember1;

        /// IOleItemContainerVtbl_AddRef
        public IOleItemContainerVtbl_AddRef AnonymousMember2;

        /// IOleItemContainerVtbl_Release
        public IOleItemContainerVtbl_Release AnonymousMember3;

        /// IOleItemContainerVtbl_ParseDisplayName
        public IOleItemContainerVtbl_ParseDisplayName AnonymousMember4;

        /// IOleItemContainerVtbl_EnumObjects
        public IOleItemContainerVtbl_EnumObjects AnonymousMember5;

        /// IOleItemContainerVtbl_LockContainer
        public IOleItemContainerVtbl_LockContainer AnonymousMember6;

        /// IOleItemContainerVtbl_GetObjectW
        public IOleItemContainerVtbl_GetObjectW AnonymousMember7;

        /// IOleItemContainerVtbl_GetObjectStorage
        public IOleItemContainerVtbl_GetObjectStorage AnonymousMember8;

        /// IOleItemContainerVtbl_IsRunning
        public IOleItemContainerVtbl_IsRunning AnonymousMember9;
    }
}