using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceFrame*
    ///fEnterMode: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceFrameVtbl_ContextSensitiveHelp(ref IOleInPlaceFrame This,
        [MarshalAs(UnmanagedType.Bool)]
        bool fEnterMode);
}