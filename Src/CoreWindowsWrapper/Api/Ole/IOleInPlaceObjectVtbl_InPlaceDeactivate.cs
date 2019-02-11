using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceObject*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceObjectVtbl_InPlaceDeactivate(ref IOleInPlaceObject This);
}