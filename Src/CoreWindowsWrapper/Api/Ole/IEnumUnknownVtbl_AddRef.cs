﻿using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IEnumUnknown*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IEnumUnknownVtbl_AddRef(ref IEnumUnknown This);
}