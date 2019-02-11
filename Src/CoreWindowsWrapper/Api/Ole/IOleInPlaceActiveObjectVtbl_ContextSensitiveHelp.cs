using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceActiveObject*
    ///fEnterMode: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceActiveObjectVtbl_ContextSensitiveHelp(ref IOleInPlaceActiveObject This,
        [MarshalAs(UnmanagedType.Bool)]
        bool fEnterMode);
}