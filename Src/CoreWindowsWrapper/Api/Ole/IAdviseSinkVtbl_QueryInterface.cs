using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IAdviseSink*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int
        IAdviseSinkVtbl_QueryInterface(ref IAdviseSink This, ref GUID riid, ref IntPtr ppvObject);
}