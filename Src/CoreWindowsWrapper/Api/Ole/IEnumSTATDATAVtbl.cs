using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IEnumSTATDATAVtbl
    {
        /// IEnumSTATDATAVtbl_QueryInterface
        public IEnumSTATDATAVtbl_QueryInterface AnonymousMember1;

        /// IEnumSTATDATAVtbl_AddRef
        public IEnumSTATDATAVtbl_AddRef AnonymousMember2;

        /// IEnumSTATDATAVtbl_Release
        public IEnumSTATDATAVtbl_Release AnonymousMember3;

        /// IEnumSTATDATAVtbl_Next
        public IEnumSTATDATAVtbl_Next AnonymousMember4;

        /// IEnumSTATDATAVtbl_Skip
        public IEnumSTATDATAVtbl_Skip AnonymousMember5;

        /// IEnumSTATDATAVtbl_Reset
        public IEnumSTATDATAVtbl_Reset AnonymousMember6;

        /// IEnumSTATDATAVtbl_Clone
        public IEnumSTATDATAVtbl_Clone AnonymousMember7;
    }
}