using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceSite*
    ///ppFrame: IOleInPlaceFrame**
    ///ppDoc: IOleInPlaceUIWindow**
    ///lprcPosRect: LPRECT->tagRECT*
    ///lprcClipRect: LPRECT->tagRECT*
    ///lpFrameInfo: LPOLEINPLACEFRAMEINFO->tagOIFI*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceSiteVtbl_GetWindowContext(ref IOleInPlaceSite This, ref IntPtr ppFrame,
        ref IntPtr ppDoc, ref tagRECT lprcPosRect, ref tagRECT lprcClipRect, ref tagOIFI lpFrameInfo);
}