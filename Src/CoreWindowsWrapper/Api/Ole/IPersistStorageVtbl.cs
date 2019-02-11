using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IPersistStorageVtbl
    {
        /// IPersistStorageVtbl_QueryInterface
        public IPersistStorageVtbl_QueryInterface AnonymousMember1;

        /// IPersistStorageVtbl_AddRef
        public IPersistStorageVtbl_AddRef AnonymousMember2;

        /// IPersistStorageVtbl_Release
        public IPersistStorageVtbl_Release AnonymousMember3;

        /// IPersistStorageVtbl_GetClassID
        public IPersistStorageVtbl_GetClassID AnonymousMember4;

        /// IPersistStorageVtbl_IsDirty
        public IPersistStorageVtbl_IsDirty AnonymousMember5;

        /// IPersistStorageVtbl_InitNew
        public IPersistStorageVtbl_InitNew AnonymousMember6;

        /// IPersistStorageVtbl_Load
        public IPersistStorageVtbl_Load AnonymousMember7;

        /// IPersistStorageVtbl_Save
        public IPersistStorageVtbl_Save AnonymousMember8;

        /// IPersistStorageVtbl_SaveCompleted
        public IPersistStorageVtbl_SaveCompleted AnonymousMember9;

        /// IPersistStorageVtbl_HandsOffStorage
        public IPersistStorageVtbl_HandsOffStorage AnonymousMember10;
    }
}