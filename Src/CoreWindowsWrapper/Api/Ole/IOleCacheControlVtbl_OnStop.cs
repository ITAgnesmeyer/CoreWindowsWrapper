using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleCacheControl*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleCacheControlVtbl_OnStop(ref IOleCacheControl This);
}