using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceObject*
    ///lprcPosRect: LPCRECT->RECT*
    ///lprcClipRect: LPCRECT->RECT*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceObjectVtbl_SetObjectRects(ref IOleInPlaceObject This, ref tagRECT lprcPosRect,
        ref tagRECT lprcClipRect);
}