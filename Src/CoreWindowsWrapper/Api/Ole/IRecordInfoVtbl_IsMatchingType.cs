using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: BOOL->int
    ///This: IRecordInfo*
    ///pRecordInfo: IRecordInfo*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRecordInfoVtbl_IsMatchingType(ref IRecordInfo This, ref IRecordInfo pRecordInfo);
}