using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IEnumStringVtbl
    {
        /// IEnumStringVtbl_QueryInterface
        public IEnumStringVtbl_QueryInterface AnonymousMember1;

        /// IEnumStringVtbl_AddRef
        public IEnumStringVtbl_AddRef AnonymousMember2;

        /// IEnumStringVtbl_Release
        public IEnumStringVtbl_Release AnonymousMember3;

        /// IEnumStringVtbl_Next
        public IEnumStringVtbl_Next AnonymousMember4;

        /// IEnumStringVtbl_Skip
        public IEnumStringVtbl_Skip AnonymousMember5;

        /// IEnumStringVtbl_Reset
        public IEnumStringVtbl_Reset AnonymousMember6;

        /// IEnumStringVtbl_Clone
        public IEnumStringVtbl_Clone AnonymousMember7;
    }
}