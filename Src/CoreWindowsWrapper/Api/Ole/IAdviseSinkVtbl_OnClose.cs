using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: void
    ///This: IAdviseSink*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate void IAdviseSinkVtbl_OnClose(ref IAdviseSink This);
}