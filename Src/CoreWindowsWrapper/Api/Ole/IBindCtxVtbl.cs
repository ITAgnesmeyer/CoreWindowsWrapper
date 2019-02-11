using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IBindCtxVtbl
    {
        /// IBindCtxVtbl_QueryInterface
        public IBindCtxVtbl_QueryInterface AnonymousMember1;

        /// IBindCtxVtbl_AddRef
        public IBindCtxVtbl_AddRef AnonymousMember2;

        /// IBindCtxVtbl_Release
        public IBindCtxVtbl_Release AnonymousMember3;

        /// IBindCtxVtbl_RegisterObjectBound
        public IBindCtxVtbl_RegisterObjectBound AnonymousMember4;

        /// IBindCtxVtbl_RevokeObjectBound
        public IBindCtxVtbl_RevokeObjectBound AnonymousMember5;

        /// IBindCtxVtbl_ReleaseBoundObjects
        public IBindCtxVtbl_ReleaseBoundObjects AnonymousMember6;

        /// IBindCtxVtbl_SetBindOptions
        public IBindCtxVtbl_SetBindOptions AnonymousMember7;

        /// IBindCtxVtbl_GetBindOptions
        public IBindCtxVtbl_GetBindOptions AnonymousMember8;

        /// IBindCtxVtbl_GetRunningObjectTable
        public IBindCtxVtbl_GetRunningObjectTable AnonymousMember9;

        /// IBindCtxVtbl_RegisterObjectParam
        public IBindCtxVtbl_RegisterObjectParam AnonymousMember10;

        /// IBindCtxVtbl_GetObjectParam
        public IBindCtxVtbl_GetObjectParam AnonymousMember11;

        /// IBindCtxVtbl_EnumObjectParam
        public IBindCtxVtbl_EnumObjectParam AnonymousMember12;

        /// IBindCtxVtbl_RevokeObjectParam
        public IBindCtxVtbl_RevokeObjectParam AnonymousMember13;
    }
}