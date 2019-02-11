using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IMonikerVtbl
    {
        /// IMonikerVtbl_QueryInterface
        public IMonikerVtbl_QueryInterface AnonymousMember1;

        /// IMonikerVtbl_AddRef
        public IMonikerVtbl_AddRef AnonymousMember2;

        /// IMonikerVtbl_Release
        public IMonikerVtbl_Release AnonymousMember3;

        /// IMonikerVtbl_GetClassID
        public IMonikerVtbl_GetClassID AnonymousMember4;

        /// IMonikerVtbl_IsDirty
        public IMonikerVtbl_IsDirty AnonymousMember5;

        /// IMonikerVtbl_Load
        public IMonikerVtbl_Load AnonymousMember6;

        /// IMonikerVtbl_Save
        public IMonikerVtbl_Save AnonymousMember7;

        /// IMonikerVtbl_GetSizeMax
        public IMonikerVtbl_GetSizeMax AnonymousMember8;

        /// IMonikerVtbl_BindToObject
        public IMonikerVtbl_BindToObject AnonymousMember9;

        /// IMonikerVtbl_BindToStorage
        public IMonikerVtbl_BindToStorage AnonymousMember10;

        /// IMonikerVtbl_Reduce
        public IMonikerVtbl_Reduce AnonymousMember11;

        /// IMonikerVtbl_ComposeWith
        public IMonikerVtbl_ComposeWith AnonymousMember12;

        /// IMonikerVtbl_Enum
        public IMonikerVtbl_Enum AnonymousMember13;

        /// IMonikerVtbl_IsEqual
        public IMonikerVtbl_IsEqual AnonymousMember14;

        /// IMonikerVtbl_Hash
        public IMonikerVtbl_Hash AnonymousMember15;

        /// IMonikerVtbl_IsRunning
        public IMonikerVtbl_IsRunning AnonymousMember16;

        /// IMonikerVtbl_GetTimeOfLastChange
        public IMonikerVtbl_GetTimeOfLastChange AnonymousMember17;

        /// IMonikerVtbl_Inverse
        public IMonikerVtbl_Inverse AnonymousMember18;

        /// IMonikerVtbl_CommonPrefixWith
        public IMonikerVtbl_CommonPrefixWith AnonymousMember19;

        /// IMonikerVtbl_RelativePathTo
        public IMonikerVtbl_RelativePathTo AnonymousMember20;

        /// IMonikerVtbl_GetDisplayName
        public IMonikerVtbl_GetDisplayName AnonymousMember21;

        /// IMonikerVtbl_ParseDisplayName
        public IMonikerVtbl_ParseDisplayName AnonymousMember22;

        /// IMonikerVtbl_IsSystemMoniker
        public IMonikerVtbl_IsSystemMoniker AnonymousMember23;
    }
}