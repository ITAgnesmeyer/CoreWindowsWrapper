using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceActiveObject*
    ///phwnd: HWND*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int
        IOleInPlaceActiveObjectVtbl_GetWindow(ref IOleInPlaceActiveObject This, ref IntPtr phwnd);
}