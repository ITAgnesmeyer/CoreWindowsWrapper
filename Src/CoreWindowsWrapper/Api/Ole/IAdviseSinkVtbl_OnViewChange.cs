using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: void
    ///This: IAdviseSink*
    ///dwAspect: DWORD->unsigned int
    ///lindex: LONG->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate void IAdviseSinkVtbl_OnViewChange(ref IAdviseSink This, uint dwAspect, int lindex);
}