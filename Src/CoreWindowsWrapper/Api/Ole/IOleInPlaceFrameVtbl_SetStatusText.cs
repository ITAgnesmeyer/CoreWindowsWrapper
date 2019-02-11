using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceFrame*
    ///pszStatusText: LPCOLESTR->OLECHAR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceFrameVtbl_SetStatusText(ref IOleInPlaceFrame This,
        [In()]
        [MarshalAs(UnmanagedType.LPWStr)]
        string pszStatusText);
}