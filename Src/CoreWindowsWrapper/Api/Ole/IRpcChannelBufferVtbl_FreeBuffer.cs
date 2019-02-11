using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRpcChannelBuffer*
    ///pMessage: RPCOLEMESSAGE*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRpcChannelBufferVtbl_FreeBuffer(ref IRpcChannelBuffer This, ref tagRPCOLEMESSAGE pMessage);
}