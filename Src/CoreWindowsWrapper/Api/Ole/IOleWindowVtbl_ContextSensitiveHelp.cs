using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleWindow*
    ///fEnterMode: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleWindowVtbl_ContextSensitiveHelp(ref IOleWindow This,
        [MarshalAs(UnmanagedType.Bool)]
        bool fEnterMode);
}