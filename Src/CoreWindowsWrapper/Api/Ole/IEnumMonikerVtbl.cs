using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IEnumMonikerVtbl
    {
        /// IEnumMonikerVtbl_QueryInterface
        public IEnumMonikerVtbl_QueryInterface AnonymousMember1;

        /// IEnumMonikerVtbl_AddRef
        public IEnumMonikerVtbl_AddRef AnonymousMember2;

        /// IEnumMonikerVtbl_Release
        public IEnumMonikerVtbl_Release AnonymousMember3;

        /// IEnumMonikerVtbl_Next
        public IEnumMonikerVtbl_Next AnonymousMember4;

        /// IEnumMonikerVtbl_Skip
        public IEnumMonikerVtbl_Skip AnonymousMember5;

        /// IEnumMonikerVtbl_Reset
        public IEnumMonikerVtbl_Reset AnonymousMember6;

        /// IEnumMonikerVtbl_Clone
        public IEnumMonikerVtbl_Clone AnonymousMember7;
    }
}