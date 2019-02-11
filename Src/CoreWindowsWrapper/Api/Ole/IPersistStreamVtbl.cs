using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IPersistStreamVtbl
    {
        /// IPersistStreamVtbl_QueryInterface
        public IPersistStreamVtbl_QueryInterface AnonymousMember1;

        /// IPersistStreamVtbl_AddRef
        public IPersistStreamVtbl_AddRef AnonymousMember2;

        /// IPersistStreamVtbl_Release
        public IPersistStreamVtbl_Release AnonymousMember3;

        /// IPersistStreamVtbl_GetClassID
        public IPersistStreamVtbl_GetClassID AnonymousMember4;

        /// IPersistStreamVtbl_IsDirty
        public IPersistStreamVtbl_IsDirty AnonymousMember5;

        /// IPersistStreamVtbl_Load
        public IPersistStreamVtbl_Load AnonymousMember6;

        /// IPersistStreamVtbl_Save
        public IPersistStreamVtbl_Save AnonymousMember7;

        /// IPersistStreamVtbl_GetSizeMax
        public IPersistStreamVtbl_GetSizeMax AnonymousMember8;
    }
}