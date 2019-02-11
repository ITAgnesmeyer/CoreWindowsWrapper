using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRpcChannelBuffer*
    ///pMessage: RPCOLEMESSAGE*
    ///riid: IID*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRpcChannelBufferVtbl_GetBuffer(ref IRpcChannelBuffer This, ref tagRPCOLEMESSAGE pMessage,
        ref GUID riid);
}