using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRpcChannelBuffer*
    ///pMessage: RPCOLEMESSAGE*
    ///pStatus: ULONG*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRpcChannelBufferVtbl_SendReceive(ref IRpcChannelBuffer This, ref tagRPCOLEMESSAGE pMessage,
        ref uint pStatus);
}