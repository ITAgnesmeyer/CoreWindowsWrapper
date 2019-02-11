﻿using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRecordInfo*
    ///pvExisting: PVOID->void*
    ///pvNew: PVOID->void*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRecordInfoVtbl_RecordCopy(ref IRecordInfo This, IntPtr pvExisting, IntPtr pvNew);
}