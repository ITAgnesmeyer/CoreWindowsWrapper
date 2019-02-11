using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IAdviseSink*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IAdviseSinkVtbl_AddRef(ref IAdviseSink This);
}