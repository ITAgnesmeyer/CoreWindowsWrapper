using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceUIWindow*
    ///fEnterMode: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceUIWindowVtbl_ContextSensitiveHelp(ref IOleInPlaceUIWindow This,
        [MarshalAs(UnmanagedType.Bool)]
        bool fEnterMode);
}