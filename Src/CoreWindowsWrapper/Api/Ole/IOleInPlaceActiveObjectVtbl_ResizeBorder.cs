using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceActiveObject*
    ///prcBorder: LPCRECT->RECT*
    ///pUIWindow: IOleInPlaceUIWindow*
    ///fFrameWindow: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceActiveObjectVtbl_ResizeBorder(ref IOleInPlaceActiveObject This,
        ref tagRECT prcBorder, ref IOleInPlaceUIWindow pUIWindow,
        [MarshalAs(UnmanagedType.Bool)]
        bool fFrameWindow);
}