using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IOleInPlaceUIWindow*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IOleInPlaceUIWindowVtbl_AddRef(ref IOleInPlaceUIWindow This);
}