using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRpcStubBuffer*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRpcStubBufferVtbl_QueryInterface(ref IRpcStubBuffer This, ref GUID riid,
        ref IntPtr ppvObject);
}