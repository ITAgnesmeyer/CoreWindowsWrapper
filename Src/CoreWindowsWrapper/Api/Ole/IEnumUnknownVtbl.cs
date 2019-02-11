using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IEnumUnknownVtbl
    {
        /// IEnumUnknownVtbl_QueryInterface
        public IEnumUnknownVtbl_QueryInterface AnonymousMember1;

        /// IEnumUnknownVtbl_AddRef
        public IEnumUnknownVtbl_AddRef AnonymousMember2;

        /// IEnumUnknownVtbl_Release
        public IEnumUnknownVtbl_Release AnonymousMember3;

        /// IEnumUnknownVtbl_Next
        public IEnumUnknownVtbl_Next AnonymousMember4;

        /// IEnumUnknownVtbl_Skip
        public IEnumUnknownVtbl_Skip AnonymousMember5;

        /// IEnumUnknownVtbl_Reset
        public IEnumUnknownVtbl_Reset AnonymousMember6;

        /// IEnumUnknownVtbl_Clone
        public IEnumUnknownVtbl_Clone AnonymousMember7;
    }
}