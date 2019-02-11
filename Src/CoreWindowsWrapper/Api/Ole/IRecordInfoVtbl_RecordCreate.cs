using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: PVOID->void*
    ///This: IRecordInfo*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate IntPtr IRecordInfoVtbl_RecordCreate(ref IRecordInfo This);
}