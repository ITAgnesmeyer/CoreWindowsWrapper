using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IRpcChannelBuffer*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IRpcChannelBufferVtbl_Release(ref IRpcChannelBuffer This);
}