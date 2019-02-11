using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IEnumFORMATETCVtbl
    {
        /// IEnumFORMATETCVtbl_QueryInterface
        public IEnumFORMATETCVtbl_QueryInterface AnonymousMember1;

        /// IEnumFORMATETCVtbl_AddRef
        public IEnumFORMATETCVtbl_AddRef AnonymousMember2;

        /// IEnumFORMATETCVtbl_Release
        public IEnumFORMATETCVtbl_Release AnonymousMember3;

        /// IEnumFORMATETCVtbl_Next
        public IEnumFORMATETCVtbl_Next AnonymousMember4;

        /// IEnumFORMATETCVtbl_Skip
        public IEnumFORMATETCVtbl_Skip AnonymousMember5;

        /// IEnumFORMATETCVtbl_Reset
        public IEnumFORMATETCVtbl_Reset AnonymousMember6;

        /// IEnumFORMATETCVtbl_Clone
        public IEnumFORMATETCVtbl_Clone AnonymousMember7;
    }
}