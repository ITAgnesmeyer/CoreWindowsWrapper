using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRpcStubBuffer*
    ///pUnkServer: IUnknown*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRpcStubBufferVtbl_Connect(ref IRpcStubBuffer This, ref IUnknown pUnkServer);
}