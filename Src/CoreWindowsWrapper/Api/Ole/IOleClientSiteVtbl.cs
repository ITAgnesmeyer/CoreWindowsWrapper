using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleClientSiteVtbl
    {
        /// IOleClientSiteVtbl_QueryInterface
        public IOleClientSiteVtbl_QueryInterface QueryInterface;

        /// IOleClientSiteVtbl_AddRef
        public IOleClientSiteVtbl_AddRef AddRef;

        /// IOleClientSiteVtbl_Release
        public IOleClientSiteVtbl_Release Release;

        /// IOleClientSiteVtbl_SaveObject
        public IOleClientSiteVtbl_SaveObject SaveObject;

        /// IOleClientSiteVtbl_GetMoniker
        public IOleClientSiteVtbl_GetMoniker GetMoniker;

        /// IOleClientSiteVtbl_GetContainer
        public IOleClientSiteVtbl_GetContainer GetContainer;

        /// IOleClientSiteVtbl_ShowObject
        public IOleClientSiteVtbl_ShowObject ShowObject;

        /// IOleClientSiteVtbl_OnShowWindow
        public IOleClientSiteVtbl_OnShowWindow OnShowWindow;

        /// IOleClientSiteVtbl_RequestNewObjectLayout
        public IOleClientSiteVtbl_RequestNewObjectLayout RequestNewObjectLayout;
    }
}