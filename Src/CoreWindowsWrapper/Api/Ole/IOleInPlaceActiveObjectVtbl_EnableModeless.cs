using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceActiveObject*
    ///fEnable: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceActiveObjectVtbl_EnableModeless(ref IOleInPlaceActiveObject This,
        [MarshalAs(UnmanagedType.Bool)]
        bool fEnable);
}