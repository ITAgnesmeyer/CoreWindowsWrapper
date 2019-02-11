using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleInPlaceActiveObjectVtbl
    {
        /// IOleInPlaceActiveObjectVtbl_QueryInterface
        public IOleInPlaceActiveObjectVtbl_QueryInterface AnonymousMember1;

        /// IOleInPlaceActiveObjectVtbl_AddRef
        public IOleInPlaceActiveObjectVtbl_AddRef AnonymousMember2;

        /// IOleInPlaceActiveObjectVtbl_Release
        public IOleInPlaceActiveObjectVtbl_Release AnonymousMember3;

        /// IOleInPlaceActiveObjectVtbl_GetWindow
        public IOleInPlaceActiveObjectVtbl_GetWindow AnonymousMember4;

        /// IOleInPlaceActiveObjectVtbl_ContextSensitiveHelp
        public IOleInPlaceActiveObjectVtbl_ContextSensitiveHelp AnonymousMember5;

        /// IOleInPlaceActiveObjectVtbl_TranslateAcceleratorW
        public IOleInPlaceActiveObjectVtbl_TranslateAcceleratorW AnonymousMember6;

        /// IOleInPlaceActiveObjectVtbl_OnFrameWindowActivate
        public IOleInPlaceActiveObjectVtbl_OnFrameWindowActivate AnonymousMember7;

        /// IOleInPlaceActiveObjectVtbl_OnDocWindowActivate
        public IOleInPlaceActiveObjectVtbl_OnDocWindowActivate AnonymousMember8;

        /// IOleInPlaceActiveObjectVtbl_ResizeBorder
        public IOleInPlaceActiveObjectVtbl_ResizeBorder AnonymousMember9;

        /// IOleInPlaceActiveObjectVtbl_EnableModeless
        public IOleInPlaceActiveObjectVtbl_EnableModeless AnonymousMember10;
    }
}