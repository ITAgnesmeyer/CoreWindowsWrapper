using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceFrame*
    ///hmenuShared: HMENU->HMENU__*
    ///holemenu: HOLEMENU->HGLOBAL->HANDLE->void*
    ///hwndActiveObject: HWND->HWND__*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceFrameVtbl_SetMenu(ref IOleInPlaceFrame This, IntPtr hmenuShared,
        IntPtr holemenu, IntPtr hwndActiveObject);
}