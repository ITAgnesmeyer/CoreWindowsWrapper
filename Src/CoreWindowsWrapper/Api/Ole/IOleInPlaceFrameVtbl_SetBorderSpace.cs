using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceFrame*
    ///pborderwidths: LPCBORDERWIDTHS->LPCRECT->RECT*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceFrameVtbl_SetBorderSpace(ref IOleInPlaceFrame This, ref tagRECT pborderwidths);
}