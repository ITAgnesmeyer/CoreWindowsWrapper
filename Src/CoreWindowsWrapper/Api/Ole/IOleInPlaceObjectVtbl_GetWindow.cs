using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceObject*
    ///phwnd: HWND*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceObjectVtbl_GetWindow(ref IOleInPlaceObject This, ref IntPtr phwnd);
}