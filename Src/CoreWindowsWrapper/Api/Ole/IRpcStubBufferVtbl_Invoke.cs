using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRpcStubBuffer*
    ///_prpcmsg: RPCOLEMESSAGE*
    ///_pRpcChannelBuffer: IRpcChannelBuffer*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRpcStubBufferVtbl_Invoke(ref IRpcStubBuffer This, ref tagRPCOLEMESSAGE _prpcmsg,
        ref IRpcChannelBuffer _pRpcChannelBuffer);
}