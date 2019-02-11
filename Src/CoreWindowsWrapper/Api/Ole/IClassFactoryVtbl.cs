using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IClassFactoryVtbl
    {
        /// IClassFactoryVtbl_QueryInterface
        public IClassFactoryVtbl_QueryInterface AnonymousMember1;

        /// IClassFactoryVtbl_AddRef
        public IClassFactoryVtbl_AddRef AnonymousMember2;

        /// IClassFactoryVtbl_Release
        public IClassFactoryVtbl_Release AnonymousMember3;

        /// IClassFactoryVtbl_CreateInstance
        public IClassFactoryVtbl_CreateInstance AnonymousMember4;

        /// IClassFactoryVtbl_LockServer
        public IClassFactoryVtbl_LockServer AnonymousMember5;
    }
}