using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleInPlaceFrameVtbl
    {
        /// IOleInPlaceFrameVtbl_QueryInterface
        public IOleInPlaceFrameVtbl_QueryInterface AnonymousMember1;

        /// IOleInPlaceFrameVtbl_AddRef
        public IOleInPlaceFrameVtbl_AddRef AnonymousMember2;

        /// IOleInPlaceFrameVtbl_Release
        public IOleInPlaceFrameVtbl_Release AnonymousMember3;

        /// IOleInPlaceFrameVtbl_GetWindow
        public IOleInPlaceFrameVtbl_GetWindow AnonymousMember4;

        /// IOleInPlaceFrameVtbl_ContextSensitiveHelp
        public IOleInPlaceFrameVtbl_ContextSensitiveHelp AnonymousMember5;

        /// IOleInPlaceFrameVtbl_GetBorder
        public IOleInPlaceFrameVtbl_GetBorder AnonymousMember6;

        /// IOleInPlaceFrameVtbl_RequestBorderSpace
        public IOleInPlaceFrameVtbl_RequestBorderSpace AnonymousMember7;

        /// IOleInPlaceFrameVtbl_SetBorderSpace
        public IOleInPlaceFrameVtbl_SetBorderSpace AnonymousMember8;

        /// IOleInPlaceFrameVtbl_SetActiveObject
        public IOleInPlaceFrameVtbl_SetActiveObject AnonymousMember9;

        /// IOleInPlaceFrameVtbl_InsertMenus
        public IOleInPlaceFrameVtbl_InsertMenus AnonymousMember10;

        /// IOleInPlaceFrameVtbl_SetMenu
        public IOleInPlaceFrameVtbl_SetMenu AnonymousMember11;

        /// IOleInPlaceFrameVtbl_RemoveMenus
        public IOleInPlaceFrameVtbl_RemoveMenus AnonymousMember12;

        /// IOleInPlaceFrameVtbl_SetStatusText
        public IOleInPlaceFrameVtbl_SetStatusText AnonymousMember13;

        /// IOleInPlaceFrameVtbl_EnableModeless
        public IOleInPlaceFrameVtbl_EnableModeless AnonymousMember14;

        /// IOleInPlaceFrameVtbl_TranslateAcceleratorW
        public IOleInPlaceFrameVtbl_TranslateAcceleratorW AnonymousMember15;
    }
}