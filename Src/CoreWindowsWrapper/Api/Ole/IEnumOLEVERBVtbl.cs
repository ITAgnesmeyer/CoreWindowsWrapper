using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IEnumOLEVERBVtbl
    {
        /// IEnumOLEVERBVtbl_QueryInterface
        public IEnumOLEVERBVtbl_QueryInterface AnonymousMember1;

        /// IEnumOLEVERBVtbl_AddRef
        public IEnumOLEVERBVtbl_AddRef AnonymousMember2;

        /// IEnumOLEVERBVtbl_Release
        public IEnumOLEVERBVtbl_Release AnonymousMember3;

        /// IEnumOLEVERBVtbl_Next
        public IEnumOLEVERBVtbl_Next AnonymousMember4;

        /// IEnumOLEVERBVtbl_Skip
        public IEnumOLEVERBVtbl_Skip AnonymousMember5;

        /// IEnumOLEVERBVtbl_Reset
        public IEnumOLEVERBVtbl_Reset AnonymousMember6;

        /// IEnumOLEVERBVtbl_Clone
        public IEnumOLEVERBVtbl_Clone AnonymousMember7;
    }
}