using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IEnumSTATSTGVtbl
    {
        /// IEnumSTATSTGVtbl_QueryInterface
        public IEnumSTATSTGVtbl_QueryInterface AnonymousMember1;

        /// IEnumSTATSTGVtbl_AddRef
        public IEnumSTATSTGVtbl_AddRef AnonymousMember2;

        /// IEnumSTATSTGVtbl_Release
        public IEnumSTATSTGVtbl_Release AnonymousMember3;

        /// IEnumSTATSTGVtbl_Next
        public IEnumSTATSTGVtbl_Next AnonymousMember4;

        /// IEnumSTATSTGVtbl_Skip
        public IEnumSTATSTGVtbl_Skip AnonymousMember5;

        /// IEnumSTATSTGVtbl_Reset
        public IEnumSTATSTGVtbl_Reset AnonymousMember6;

        /// IEnumSTATSTGVtbl_Clone
        public IEnumSTATSTGVtbl_Clone AnonymousMember7;
    }
}