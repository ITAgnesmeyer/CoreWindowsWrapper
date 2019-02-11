using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceSite*
    ///phwnd: HWND*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceSiteVtbl_GetWindow(ref IOleInPlaceSite This, ref IntPtr phwnd);
}