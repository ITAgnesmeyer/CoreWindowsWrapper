using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceUIWindow*
    ///pborderwidths: LPCBORDERWIDTHS->LPCRECT->RECT*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceUIWindowVtbl_SetBorderSpace(ref IOleInPlaceUIWindow This, ref tagRECT pborderwidths);
}