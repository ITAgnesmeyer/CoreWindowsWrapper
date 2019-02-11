using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceFrame*
    ///phwnd: HWND*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceFrameVtbl_GetWindow(ref IOleInPlaceFrame This, ref IntPtr phwnd);
}