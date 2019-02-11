using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleWindowVtbl
    {
        /// IOleWindowVtbl_QueryInterface
        public IOleWindowVtbl_QueryInterface AnonymousMember1;

        /// IOleWindowVtbl_AddRef
        public IOleWindowVtbl_AddRef AnonymousMember2;

        /// IOleWindowVtbl_Release
        public IOleWindowVtbl_Release AnonymousMember3;

        /// IOleWindowVtbl_GetWindow
        public IOleWindowVtbl_GetWindow AnonymousMember4;

        /// IOleWindowVtbl_ContextSensitiveHelp
        public IOleWindowVtbl_ContextSensitiveHelp AnonymousMember5;
    }
}