using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleCache2Vtbl
    {
        /// IOleCache2Vtbl_QueryInterface
        public IOleCache2Vtbl_QueryInterface AnonymousMember1;

        /// IOleCache2Vtbl_AddRef
        public IOleCache2Vtbl_AddRef AnonymousMember2;

        /// IOleCache2Vtbl_Release
        public IOleCache2Vtbl_Release AnonymousMember3;

        /// IOleCache2Vtbl_Cache
        public IOleCache2Vtbl_Cache AnonymousMember4;

        /// IOleCache2Vtbl_Uncache
        public IOleCache2Vtbl_Uncache AnonymousMember5;

        /// IOleCache2Vtbl_EnumCache
        public IOleCache2Vtbl_EnumCache AnonymousMember6;

        /// IOleCache2Vtbl_InitCache
        public IOleCache2Vtbl_InitCache AnonymousMember7;

        /// IOleCache2Vtbl_SetData
        public IOleCache2Vtbl_SetData AnonymousMember8;

        /// IOleCache2Vtbl_UpdateCache
        public IOleCache2Vtbl_UpdateCache AnonymousMember9;

        /// IOleCache2Vtbl_DiscardCache
        public IOleCache2Vtbl_DiscardCache AnonymousMember10;
    }
}