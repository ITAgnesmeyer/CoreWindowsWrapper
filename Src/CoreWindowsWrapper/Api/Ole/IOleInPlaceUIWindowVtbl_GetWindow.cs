using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceUIWindow*
    ///phwnd: HWND*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceUIWindowVtbl_GetWindow(ref IOleInPlaceUIWindow This, ref IntPtr phwnd);
}