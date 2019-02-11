using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleCacheControlVtbl
    {
        /// IOleCacheControlVtbl_QueryInterface
        public IOleCacheControlVtbl_QueryInterface AnonymousMember1;

        /// IOleCacheControlVtbl_AddRef
        public IOleCacheControlVtbl_AddRef AnonymousMember2;

        /// IOleCacheControlVtbl_Release
        public IOleCacheControlVtbl_Release AnonymousMember3;

        /// IOleCacheControlVtbl_OnRun
        public IOleCacheControlVtbl_OnRun AnonymousMember4;

        /// IOleCacheControlVtbl_OnStop
        public IOleCacheControlVtbl_OnStop AnonymousMember5;
    }
}