using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleLink*
    ///pdwUpdateOpt: DWORD*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleLinkVtbl_GetUpdateOptions(ref IOleLink This, ref uint pdwUpdateOpt);
}