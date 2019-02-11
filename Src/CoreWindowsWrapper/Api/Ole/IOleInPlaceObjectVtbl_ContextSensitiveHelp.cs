using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceObject*
    ///fEnterMode: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceObjectVtbl_ContextSensitiveHelp(ref IOleInPlaceObject This,
        [MarshalAs(UnmanagedType.Bool)]
        bool fEnterMode);
}