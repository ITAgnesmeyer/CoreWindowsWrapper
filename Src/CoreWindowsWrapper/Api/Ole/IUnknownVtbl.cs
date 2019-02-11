using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IUnknownVtbl
    {
        /// IUnknownVtbl_QueryInterface
        public IUnknownVtbl_QueryInterface AnonymousMember1;

        /// IUnknownVtbl_AddRef
        public IUnknownVtbl_AddRef AnonymousMember2;

        /// IUnknownVtbl_Release
        public IUnknownVtbl_Release AnonymousMember3;
    }
}