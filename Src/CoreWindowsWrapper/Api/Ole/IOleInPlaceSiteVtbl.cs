using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleInPlaceSiteVtbl
    {
        /// IOleInPlaceSiteVtbl_QueryInterface
        public IOleInPlaceSiteVtbl_QueryInterface QueryInterface;

        /// IOleInPlaceSiteVtbl_AddRef
        public IOleInPlaceSiteVtbl_AddRef AddRef;

        /// IOleInPlaceSiteVtbl_Release
        public IOleInPlaceSiteVtbl_Release Release;

        /// IOleInPlaceSiteVtbl_GetWindow
        public IOleInPlaceSiteVtbl_GetWindow GetWindow;

        /// IOleInPlaceSiteVtbl_ContextSensitiveHelp
        public IOleInPlaceSiteVtbl_ContextSensitiveHelp ContextSensitiveHelp;

        /// IOleInPlaceSiteVtbl_CanInPlaceActivate
        public IOleInPlaceSiteVtbl_CanInPlaceActivate CanInPlaceActivate;

        /// IOleInPlaceSiteVtbl_OnInPlaceActivate
        public IOleInPlaceSiteVtbl_OnInPlaceActivate OnInPlaceActivate;

        /// IOleInPlaceSiteVtbl_OnUIActivate
        public IOleInPlaceSiteVtbl_OnUIActivate OnUIActivate;

        /// IOleInPlaceSiteVtbl_GetWindowContext
        public IOleInPlaceSiteVtbl_GetWindowContext GetWindowContext;

        /// IOleInPlaceSiteVtbl_Scroll
        public IOleInPlaceSiteVtbl_Scroll Scroll;

        /// IOleInPlaceSiteVtbl_OnUIDeactivate
        public IOleInPlaceSiteVtbl_OnUIDeactivate OnUIDeactivate;

        /// IOleInPlaceSiteVtbl_OnInPlaceDeactivate
        public IOleInPlaceSiteVtbl_OnInPlaceDeactivate OnInPlaceDeactivate;

        /// IOleInPlaceSiteVtbl_DiscardUndoState
        public IOleInPlaceSiteVtbl_DiscardUndoState DiscardUndoState;

        /// IOleInPlaceSiteVtbl_DeactivateAndUndo
        public IOleInPlaceSiteVtbl_DeactivateAndUndo DeactivateAndUndo;

        /// IOleInPlaceSiteVtbl_OnPosRectChange
        public IOleInPlaceSiteVtbl_OnPosRectChange OnPosRectChange;
    }
}