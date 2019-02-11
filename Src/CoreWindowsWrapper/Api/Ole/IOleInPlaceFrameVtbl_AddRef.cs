using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IOleInPlaceFrame*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IOleInPlaceFrameVtbl_AddRef(ref IOleInPlaceFrame This);
}