﻿using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRpcChannelBuffer*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRpcChannelBufferVtbl_QueryInterface(ref IRpcChannelBuffer This, ref GUID riid,
        ref IntPtr ppvObject);
}