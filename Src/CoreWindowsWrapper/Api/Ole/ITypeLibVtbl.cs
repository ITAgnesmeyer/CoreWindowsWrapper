using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ITypeLibVtbl
    {
        /// ITypeLibVtbl_QueryInterface
        public ITypeLibVtbl_QueryInterface AnonymousMember1;

        /// ITypeLibVtbl_AddRef
        public ITypeLibVtbl_AddRef AnonymousMember2;

        /// ITypeLibVtbl_Release
        public ITypeLibVtbl_Release AnonymousMember3;

        /// ITypeLibVtbl_GetTypeInfoCount
        public ITypeLibVtbl_GetTypeInfoCount AnonymousMember4;

        /// ITypeLibVtbl_GetTypeInfo
        public ITypeLibVtbl_GetTypeInfo AnonymousMember5;

        /// ITypeLibVtbl_GetTypeInfoType
        public ITypeLibVtbl_GetTypeInfoType AnonymousMember6;

        /// ITypeLibVtbl_GetTypeInfoOfGuid
        public ITypeLibVtbl_GetTypeInfoOfGuid AnonymousMember7;

        /// ITypeLibVtbl_GetLibAttr
        public ITypeLibVtbl_GetLibAttr AnonymousMember8;

        /// ITypeLibVtbl_GetTypeComp
        public ITypeLibVtbl_GetTypeComp AnonymousMember9;

        /// ITypeLibVtbl_GetDocumentation
        public ITypeLibVtbl_GetDocumentation AnonymousMember10;

        /// ITypeLibVtbl_IsName
        public ITypeLibVtbl_IsName AnonymousMember11;

        /// ITypeLibVtbl_FindName
        public ITypeLibVtbl_FindName AnonymousMember12;

        /// ITypeLibVtbl_ReleaseTLibAttr
        public ITypeLibVtbl_ReleaseTLibAttr AnonymousMember13;
    }
}