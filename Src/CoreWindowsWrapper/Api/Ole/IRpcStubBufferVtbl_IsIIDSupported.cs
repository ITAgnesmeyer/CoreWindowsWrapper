using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: IRpcStubBuffer*
    ///This: IRpcStubBuffer*
    ///riid: IID*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate IntPtr IRpcStubBufferVtbl_IsIIDSupported(ref IRpcStubBuffer This, ref GUID riid);
}