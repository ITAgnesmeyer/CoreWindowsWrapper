using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IRecordInfoVtbl
    {
        /// IRecordInfoVtbl_QueryInterface
        public IRecordInfoVtbl_QueryInterface AnonymousMember1;

        /// IRecordInfoVtbl_AddRef
        public IRecordInfoVtbl_AddRef AnonymousMember2;

        /// IRecordInfoVtbl_Release
        public IRecordInfoVtbl_Release AnonymousMember3;

        /// IRecordInfoVtbl_RecordInit
        public IRecordInfoVtbl_RecordInit AnonymousMember4;

        /// IRecordInfoVtbl_RecordClear
        public IRecordInfoVtbl_RecordClear AnonymousMember5;

        /// IRecordInfoVtbl_RecordCopy
        public IRecordInfoVtbl_RecordCopy AnonymousMember6;

        /// IRecordInfoVtbl_GetGuid
        public IRecordInfoVtbl_GetGuid AnonymousMember7;

        /// IRecordInfoVtbl_GetName
        public IRecordInfoVtbl_GetName AnonymousMember8;

        /// IRecordInfoVtbl_GetSize
        public IRecordInfoVtbl_GetSize AnonymousMember9;

        /// IRecordInfoVtbl_GetTypeInfo
        public IRecordInfoVtbl_GetTypeInfo AnonymousMember10;

        /// IRecordInfoVtbl_GetField
        public IRecordInfoVtbl_GetField AnonymousMember11;

        /// IRecordInfoVtbl_GetFieldNoCopy
        public IRecordInfoVtbl_GetFieldNoCopy AnonymousMember12;

        /// IRecordInfoVtbl_PutField
        public IRecordInfoVtbl_PutField AnonymousMember13;

        /// IRecordInfoVtbl_PutFieldNoCopy
        public IRecordInfoVtbl_PutFieldNoCopy AnonymousMember14;

        /// IRecordInfoVtbl_GetFieldNames
        public IRecordInfoVtbl_GetFieldNames AnonymousMember15;

        /// IRecordInfoVtbl_IsMatchingType
        public IRecordInfoVtbl_IsMatchingType AnonymousMember16;

        /// IRecordInfoVtbl_RecordCreate
        public IRecordInfoVtbl_RecordCreate AnonymousMember17;

        /// IRecordInfoVtbl_RecordCreateCopy
        public IRecordInfoVtbl_RecordCreateCopy AnonymousMember18;

        /// IRecordInfoVtbl_RecordDestroy
        public IRecordInfoVtbl_RecordDestroy AnonymousMember19;
    }
}