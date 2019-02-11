using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: void
    ///This: IRpcStubBuffer*
    ///pv: void*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate void IRpcStubBufferVtbl_DebugServerRelease(ref IRpcStubBuffer This, IntPtr pv);
}