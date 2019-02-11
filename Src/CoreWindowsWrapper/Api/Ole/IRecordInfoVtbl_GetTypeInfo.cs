﻿using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRecordInfo*
    ///ppTypeInfo: ITypeInfo**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRecordInfoVtbl_GetTypeInfo(ref IRecordInfo This, ref IntPtr ppTypeInfo);
}