using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleAdviseHolderVtbl
    {
        /// IOleAdviseHolderVtbl_QueryInterface
        public IOleAdviseHolderVtbl_QueryInterface AnonymousMember1;

        /// IOleAdviseHolderVtbl_AddRef
        public IOleAdviseHolderVtbl_AddRef AnonymousMember2;

        /// IOleAdviseHolderVtbl_Release
        public IOleAdviseHolderVtbl_Release AnonymousMember3;

        /// IOleAdviseHolderVtbl_Advise
        public IOleAdviseHolderVtbl_Advise AnonymousMember4;

        /// IOleAdviseHolderVtbl_Unadvise
        public IOleAdviseHolderVtbl_Unadvise AnonymousMember5;

        /// IOleAdviseHolderVtbl_EnumAdvise
        public IOleAdviseHolderVtbl_EnumAdvise AnonymousMember6;

        /// IOleAdviseHolderVtbl_SendOnRename
        public IOleAdviseHolderVtbl_SendOnRename AnonymousMember7;

        /// IOleAdviseHolderVtbl_SendOnSave
        public IOleAdviseHolderVtbl_SendOnSave AnonymousMember8;

        /// IOleAdviseHolderVtbl_SendOnClose
        public IOleAdviseHolderVtbl_SendOnClose AnonymousMember9;
    }
}