using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleObjectVtbl
    {
        /// IOleObjectVtbl_QueryInterface
        public IOleObjectVtbl_QueryInterface AnonymousMember1;

        /// IOleObjectVtbl_AddRef
        public IOleObjectVtbl_AddRef AnonymousMember2;

        /// IOleObjectVtbl_Release
        public IOleObjectVtbl_Release AnonymousMember3;

        /// IOleObjectVtbl_SetClientSite
        public IOleObjectVtbl_SetClientSite AnonymousMember4;

        /// IOleObjectVtbl_GetClientSite
        public IOleObjectVtbl_GetClientSite AnonymousMember5;

        /// IOleObjectVtbl_SetHostNames
        public IOleObjectVtbl_SetHostNames AnonymousMember6;

        /// IOleObjectVtbl_Close
        public IOleObjectVtbl_Close AnonymousMember7;

        /// IOleObjectVtbl_SetMoniker
        public IOleObjectVtbl_SetMoniker AnonymousMember8;

        /// IOleObjectVtbl_GetMoniker
        public IOleObjectVtbl_GetMoniker AnonymousMember9;

        /// IOleObjectVtbl_InitFromData
        public IOleObjectVtbl_InitFromData AnonymousMember10;

        /// IOleObjectVtbl_GetClipboardData
        public IOleObjectVtbl_GetClipboardData AnonymousMember11;

        /// IOleObjectVtbl_DoVerb
        public IOleObjectVtbl_DoVerb AnonymousMember12;

        /// IOleObjectVtbl_EnumVerbs
        public IOleObjectVtbl_EnumVerbs AnonymousMember13;

        /// IOleObjectVtbl_Update
        public IOleObjectVtbl_Update AnonymousMember14;

        /// IOleObjectVtbl_IsUpToDate
        public IOleObjectVtbl_IsUpToDate AnonymousMember15;

        /// IOleObjectVtbl_GetUserClassID
        public IOleObjectVtbl_GetUserClassID AnonymousMember16;

        /// IOleObjectVtbl_GetUserType
        public IOleObjectVtbl_GetUserType AnonymousMember17;

        /// IOleObjectVtbl_SetExtent
        public IOleObjectVtbl_SetExtent AnonymousMember18;

        /// IOleObjectVtbl_GetExtent
        public IOleObjectVtbl_GetExtent AnonymousMember19;

        /// IOleObjectVtbl_Advise
        public IOleObjectVtbl_Advise AnonymousMember20;

        /// IOleObjectVtbl_Unadvise
        public IOleObjectVtbl_Unadvise AnonymousMember21;

        /// IOleObjectVtbl_EnumAdvise
        public IOleObjectVtbl_EnumAdvise AnonymousMember22;

        /// IOleObjectVtbl_GetMiscStatus
        public IOleObjectVtbl_GetMiscStatus AnonymousMember23;

        /// IOleObjectVtbl_SetColorScheme
        public IOleObjectVtbl_SetColorScheme AnonymousMember24;
    }
}