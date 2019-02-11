using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRpcStubBuffer*
    ///ppv: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRpcStubBufferVtbl_DebugServerQueryInterface(ref IRpcStubBuffer This, ref IntPtr ppv);
}