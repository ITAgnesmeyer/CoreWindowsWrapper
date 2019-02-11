using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IOleInPlaceActiveObject*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IOleInPlaceActiveObjectVtbl_Release(ref IOleInPlaceActiveObject This);
}