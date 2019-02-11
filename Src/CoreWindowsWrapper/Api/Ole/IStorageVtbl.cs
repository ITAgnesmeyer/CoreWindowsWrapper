using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IStorageVtbl
    {
        /// IStorageVtbl_QueryInterface
        public IStorageVtbl_QueryInterface AnonymousMember1;

        /// IStorageVtbl_AddRef
        public IStorageVtbl_AddRef AnonymousMember2;

        /// IStorageVtbl_Release
        public IStorageVtbl_Release AnonymousMember3;

        /// IStorageVtbl_CreateStream
        public IStorageVtbl_CreateStream AnonymousMember4;

        /// IStorageVtbl_OpenStream
        public IStorageVtbl_OpenStream AnonymousMember5;

        /// IStorageVtbl_CreateStorage
        public IStorageVtbl_CreateStorage AnonymousMember6;

        /// IStorageVtbl_OpenStorage
        public IStorageVtbl_OpenStorage AnonymousMember7;

        /// IStorageVtbl_CopyTo
        public IStorageVtbl_CopyTo AnonymousMember8;

        /// IStorageVtbl_MoveElementTo
        public IStorageVtbl_MoveElementTo AnonymousMember9;

        /// IStorageVtbl_Commit
        public IStorageVtbl_Commit AnonymousMember10;

        /// IStorageVtbl_Revert
        public IStorageVtbl_Revert AnonymousMember11;

        /// IStorageVtbl_EnumElements
        public IStorageVtbl_EnumElements AnonymousMember12;

        /// IStorageVtbl_DestroyElement
        public IStorageVtbl_DestroyElement AnonymousMember13;

        /// IStorageVtbl_RenameElement
        public IStorageVtbl_RenameElement AnonymousMember14;

        /// IStorageVtbl_SetElementTimes
        public IStorageVtbl_SetElementTimes AnonymousMember15;

        /// IStorageVtbl_SetClass
        public IStorageVtbl_SetClass AnonymousMember16;

        /// IStorageVtbl_SetStateBits
        public IStorageVtbl_SetStateBits AnonymousMember17;

        /// IStorageVtbl_Stat
        public IStorageVtbl_Stat AnonymousMember18;
    }
}