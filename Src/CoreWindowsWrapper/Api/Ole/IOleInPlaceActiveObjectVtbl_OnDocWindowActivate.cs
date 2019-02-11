using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceActiveObject*
    ///fActivate: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceActiveObjectVtbl_OnDocWindowActivate(ref IOleInPlaceActiveObject This,
        [MarshalAs(UnmanagedType.Bool)]
        bool fActivate);
}