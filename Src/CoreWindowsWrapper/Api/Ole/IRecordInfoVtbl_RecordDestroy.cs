using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRecordInfo*
    ///pvRecord: PVOID->void*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRecordInfoVtbl_RecordDestroy(ref IRecordInfo This, IntPtr pvRecord);
}