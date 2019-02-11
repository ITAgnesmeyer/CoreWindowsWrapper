using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceSite*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceSiteVtbl_DeactivateAndUndo(ref IOleInPlaceSite This);
}