using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceFrame*
    ///fEnable: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceFrameVtbl_EnableModeless(ref IOleInPlaceFrame This,
        [MarshalAs(UnmanagedType.Bool)]
        bool fEnable);
}