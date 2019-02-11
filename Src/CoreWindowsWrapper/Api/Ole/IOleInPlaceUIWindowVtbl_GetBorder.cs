using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceUIWindow*
    ///lprectBorder: LPRECT->tagRECT*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceUIWindowVtbl_GetBorder(ref IOleInPlaceUIWindow This, ref tagRECT lprectBorder);
}