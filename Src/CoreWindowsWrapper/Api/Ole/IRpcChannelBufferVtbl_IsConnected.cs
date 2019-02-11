using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRpcChannelBuffer*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRpcChannelBufferVtbl_IsConnected(ref IRpcChannelBuffer This);
}