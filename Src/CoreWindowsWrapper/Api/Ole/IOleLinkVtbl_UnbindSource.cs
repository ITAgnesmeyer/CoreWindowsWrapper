using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleLink*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleLinkVtbl_UnbindSource(ref IOleLink This);
}