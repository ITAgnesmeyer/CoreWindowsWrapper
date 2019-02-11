using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleInPlaceUIWindowVtbl
    {
        /// IOleInPlaceUIWindowVtbl_QueryInterface
        public IOleInPlaceUIWindowVtbl_QueryInterface AnonymousMember1;

        /// IOleInPlaceUIWindowVtbl_AddRef
        public IOleInPlaceUIWindowVtbl_AddRef AnonymousMember2;

        /// IOleInPlaceUIWindowVtbl_Release
        public IOleInPlaceUIWindowVtbl_Release AnonymousMember3;

        /// IOleInPlaceUIWindowVtbl_GetWindow
        public IOleInPlaceUIWindowVtbl_GetWindow AnonymousMember4;

        /// IOleInPlaceUIWindowVtbl_ContextSensitiveHelp
        public IOleInPlaceUIWindowVtbl_ContextSensitiveHelp AnonymousMember5;

        /// IOleInPlaceUIWindowVtbl_GetBorder
        public IOleInPlaceUIWindowVtbl_GetBorder AnonymousMember6;

        /// IOleInPlaceUIWindowVtbl_RequestBorderSpace
        public IOleInPlaceUIWindowVtbl_RequestBorderSpace AnonymousMember7;

        /// IOleInPlaceUIWindowVtbl_SetBorderSpace
        public IOleInPlaceUIWindowVtbl_SetBorderSpace AnonymousMember8;

        /// IOleInPlaceUIWindowVtbl_SetActiveObject
        public IOleInPlaceUIWindowVtbl_SetActiveObject AnonymousMember9;
    }
}