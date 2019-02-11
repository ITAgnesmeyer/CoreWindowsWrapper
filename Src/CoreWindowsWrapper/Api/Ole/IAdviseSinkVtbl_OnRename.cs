using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: void
    ///This: IAdviseSink*
    ///pmk: IMoniker*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate void IAdviseSinkVtbl_OnRename(ref IAdviseSink This, ref IMoniker pmk);
}