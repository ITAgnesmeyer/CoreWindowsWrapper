using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IStreamVtbl
    {
        /// IStreamVtbl_QueryInterface
        public IStreamVtbl_QueryInterface AnonymousMember1;

        /// IStreamVtbl_AddRef
        public IStreamVtbl_AddRef AnonymousMember2;

        /// IStreamVtbl_Release
        public IStreamVtbl_Release AnonymousMember3;

        /// IStreamVtbl_Read
        public IStreamVtbl_Read AnonymousMember4;

        /// IStreamVtbl_Write
        public IStreamVtbl_Write AnonymousMember5;

        /// IStreamVtbl_Seek
        public IStreamVtbl_Seek AnonymousMember6;

        /// IStreamVtbl_SetSize
        public IStreamVtbl_SetSize AnonymousMember7;

        /// IStreamVtbl_CopyTo
        public IStreamVtbl_CopyTo AnonymousMember8;

        /// IStreamVtbl_Commit
        public IStreamVtbl_Commit AnonymousMember9;

        /// IStreamVtbl_Revert
        public IStreamVtbl_Revert AnonymousMember10;

        /// IStreamVtbl_LockRegion
        public IStreamVtbl_LockRegion AnonymousMember11;

        /// IStreamVtbl_UnlockRegion
        public IStreamVtbl_UnlockRegion AnonymousMember12;

        /// IStreamVtbl_Stat
        public IStreamVtbl_Stat AnonymousMember13;

        /// IStreamVtbl_Clone
        public IStreamVtbl_Clone AnonymousMember14;
    }
}