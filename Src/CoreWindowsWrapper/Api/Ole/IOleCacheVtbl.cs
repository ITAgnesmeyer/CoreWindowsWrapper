using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleCacheVtbl
    {
        /// IOleCacheVtbl_QueryInterface
        public IOleCacheVtbl_QueryInterface AnonymousMember1;

        /// IOleCacheVtbl_AddRef
        public IOleCacheVtbl_AddRef AnonymousMember2;

        /// IOleCacheVtbl_Release
        public IOleCacheVtbl_Release AnonymousMember3;

        /// IOleCacheVtbl_Cache
        public IOleCacheVtbl_Cache AnonymousMember4;

        /// IOleCacheVtbl_Uncache
        public IOleCacheVtbl_Uncache AnonymousMember5;

        /// IOleCacheVtbl_EnumCache
        public IOleCacheVtbl_EnumCache AnonymousMember6;

        /// IOleCacheVtbl_InitCache
        public IOleCacheVtbl_InitCache AnonymousMember7;

        /// IOleCacheVtbl_SetData
        public IOleCacheVtbl_SetData AnonymousMember8;
    }
}