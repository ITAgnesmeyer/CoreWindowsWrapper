using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleInPlaceObjectVtbl
    {
        /// IOleInPlaceObjectVtbl_QueryInterface
        public IOleInPlaceObjectVtbl_QueryInterface AnonymousMember1;

        /// IOleInPlaceObjectVtbl_AddRef
        public IOleInPlaceObjectVtbl_AddRef AnonymousMember2;

        /// IOleInPlaceObjectVtbl_Release
        public IOleInPlaceObjectVtbl_Release AnonymousMember3;

        /// IOleInPlaceObjectVtbl_GetWindow
        public IOleInPlaceObjectVtbl_GetWindow AnonymousMember4;

        /// IOleInPlaceObjectVtbl_ContextSensitiveHelp
        public IOleInPlaceObjectVtbl_ContextSensitiveHelp AnonymousMember5;

        /// IOleInPlaceObjectVtbl_InPlaceDeactivate
        public IOleInPlaceObjectVtbl_InPlaceDeactivate AnonymousMember6;

        /// IOleInPlaceObjectVtbl_UIDeactivate
        public IOleInPlaceObjectVtbl_UIDeactivate AnonymousMember7;

        /// IOleInPlaceObjectVtbl_SetObjectRects
        public IOleInPlaceObjectVtbl_SetObjectRects AnonymousMember8;

        /// IOleInPlaceObjectVtbl_ReactivateAndUndo
        public IOleInPlaceObjectVtbl_ReactivateAndUndo AnonymousMember9;
    }
}