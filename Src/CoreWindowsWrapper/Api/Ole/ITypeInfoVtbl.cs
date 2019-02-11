using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ITypeInfoVtbl
    {
        /// ITypeInfoVtbl_QueryInterface
        public ITypeInfoVtbl_QueryInterface AnonymousMember1;

        /// ITypeInfoVtbl_AddRef
        public ITypeInfoVtbl_AddRef AnonymousMember2;

        /// ITypeInfoVtbl_Release
        public ITypeInfoVtbl_Release AnonymousMember3;

        /// ITypeInfoVtbl_GetTypeAttr
        public ITypeInfoVtbl_GetTypeAttr AnonymousMember4;

        /// ITypeInfoVtbl_GetTypeComp
        public ITypeInfoVtbl_GetTypeComp AnonymousMember5;

        /// ITypeInfoVtbl_GetFuncDesc
        public ITypeInfoVtbl_GetFuncDesc AnonymousMember6;

        /// ITypeInfoVtbl_GetVarDesc
        public ITypeInfoVtbl_GetVarDesc AnonymousMember7;

        /// ITypeInfoVtbl_GetNames
        public ITypeInfoVtbl_GetNames AnonymousMember8;

        /// ITypeInfoVtbl_GetRefTypeOfImplType
        public ITypeInfoVtbl_GetRefTypeOfImplType AnonymousMember9;

        /// ITypeInfoVtbl_GetImplTypeFlags
        public ITypeInfoVtbl_GetImplTypeFlags AnonymousMember10;

        /// ITypeInfoVtbl_GetIDsOfNames
        public ITypeInfoVtbl_GetIDsOfNames AnonymousMember11;

        /// ITypeInfoVtbl_Invoke
        public ITypeInfoVtbl_Invoke AnonymousMember12;

        /// ITypeInfoVtbl_GetDocumentation
        public ITypeInfoVtbl_GetDocumentation AnonymousMember13;

        /// ITypeInfoVtbl_GetDllEntry
        public ITypeInfoVtbl_GetDllEntry AnonymousMember14;

        /// ITypeInfoVtbl_GetRefTypeInfo
        public ITypeInfoVtbl_GetRefTypeInfo AnonymousMember15;

        /// ITypeInfoVtbl_AddressOfMember
        public ITypeInfoVtbl_AddressOfMember AnonymousMember16;

        /// ITypeInfoVtbl_CreateInstance
        public ITypeInfoVtbl_CreateInstance AnonymousMember17;

        /// ITypeInfoVtbl_GetMops
        public ITypeInfoVtbl_GetMops AnonymousMember18;

        /// ITypeInfoVtbl_GetContainingTypeLib
        public ITypeInfoVtbl_GetContainingTypeLib AnonymousMember19;

        /// ITypeInfoVtbl_ReleaseTypeAttr
        public ITypeInfoVtbl_ReleaseTypeAttr AnonymousMember20;

        /// ITypeInfoVtbl_ReleaseFuncDesc
        public ITypeInfoVtbl_ReleaseFuncDesc AnonymousMember21;

        /// ITypeInfoVtbl_ReleaseVarDesc
        public ITypeInfoVtbl_ReleaseVarDesc AnonymousMember22;
    }
}