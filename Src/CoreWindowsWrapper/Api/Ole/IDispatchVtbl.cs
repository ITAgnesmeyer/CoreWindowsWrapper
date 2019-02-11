using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IDispatchVtbl
    {
        /// IDispatchVtbl_QueryInterface
        public IDispatchVtbl_QueryInterface AnonymousMember1;

        /// IDispatchVtbl_AddRef
        public IDispatchVtbl_AddRef AnonymousMember2;

        /// IDispatchVtbl_Release
        public IDispatchVtbl_Release AnonymousMember3;

        /// IDispatchVtbl_GetTypeInfoCount
        public IDispatchVtbl_GetTypeInfoCount AnonymousMember4;

        /// IDispatchVtbl_GetTypeInfo
        public IDispatchVtbl_GetTypeInfo AnonymousMember5;

        /// IDispatchVtbl_GetIDsOfNames
        public IDispatchVtbl_GetIDsOfNames AnonymousMember6;

        /// IDispatchVtbl_Invoke
        public IDispatchVtbl_Invoke AnonymousMember7;
    }
}