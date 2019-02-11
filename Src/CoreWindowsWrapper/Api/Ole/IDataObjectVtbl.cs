using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IDataObjectVtbl
    {
        /// IDataObjectVtbl_QueryInterface
        public IDataObjectVtbl_QueryInterface AnonymousMember1;

        /// IDataObjectVtbl_AddRef
        public IDataObjectVtbl_AddRef AnonymousMember2;

        /// IDataObjectVtbl_Release
        public IDataObjectVtbl_Release AnonymousMember3;

        /// IDataObjectVtbl_GetData
        public IDataObjectVtbl_GetData AnonymousMember4;

        /// IDataObjectVtbl_GetDataHere
        public IDataObjectVtbl_GetDataHere AnonymousMember5;

        /// IDataObjectVtbl_QueryGetData
        public IDataObjectVtbl_QueryGetData AnonymousMember6;

        /// IDataObjectVtbl_GetCanonicalFormatEtc
        public IDataObjectVtbl_GetCanonicalFormatEtc AnonymousMember7;

        /// IDataObjectVtbl_SetData
        public IDataObjectVtbl_SetData AnonymousMember8;

        /// IDataObjectVtbl_EnumFormatEtc
        public IDataObjectVtbl_EnumFormatEtc AnonymousMember9;

        /// IDataObjectVtbl_DAdvise
        public IDataObjectVtbl_DAdvise AnonymousMember10;

        /// IDataObjectVtbl_DUnadvise
        public IDataObjectVtbl_DUnadvise AnonymousMember11;

        /// IDataObjectVtbl_EnumDAdvise
        public IDataObjectVtbl_EnumDAdvise AnonymousMember12;
    }
}