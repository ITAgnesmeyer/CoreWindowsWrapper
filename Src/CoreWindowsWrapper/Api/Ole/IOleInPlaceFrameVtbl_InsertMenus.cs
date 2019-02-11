using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceFrame*
    ///hmenuShared: HMENU->HMENU__*
    ///lpMenuWidths: LPOLEMENUGROUPWIDTHS->tagOleMenuGroupWidths*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceFrameVtbl_InsertMenus(ref IOleInPlaceFrame This, IntPtr hmenuShared,
        ref tagOleMenuGroupWidths lpMenuWidths);
}