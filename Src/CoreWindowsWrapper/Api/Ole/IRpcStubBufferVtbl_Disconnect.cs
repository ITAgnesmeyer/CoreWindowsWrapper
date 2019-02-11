using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: void
    ///This: IRpcStubBuffer*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate void IRpcStubBufferVtbl_Disconnect(ref IRpcStubBuffer This);
}