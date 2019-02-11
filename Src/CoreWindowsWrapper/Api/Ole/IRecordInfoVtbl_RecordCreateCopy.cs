using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRecordInfo*
    ///pvSource: PVOID->void*
    ///ppvDest: PVOID*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRecordInfoVtbl_RecordCreateCopy(ref IRecordInfo This, IntPtr pvSource,
        ref IntPtr ppvDest);
}