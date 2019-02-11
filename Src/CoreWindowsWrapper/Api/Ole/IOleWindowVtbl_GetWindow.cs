using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleWindow*
    ///phwnd: HWND*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleWindowVtbl_GetWindow(ref IOleWindow This, ref IntPtr phwnd);
}