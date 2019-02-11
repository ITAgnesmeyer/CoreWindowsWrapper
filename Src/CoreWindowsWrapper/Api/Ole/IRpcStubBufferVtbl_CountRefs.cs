using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IRpcStubBuffer*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IRpcStubBufferVtbl_CountRefs(ref IRpcStubBuffer This);
}