using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRpcChannelBuffer*
    ///pdwDestContext: DWORD*
    ///ppvDestContext: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRpcChannelBufferVtbl_GetDestCtx(ref IRpcChannelBuffer This, ref uint pdwDestContext,
        ref IntPtr ppvDestContext);
}