using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceFrame*
    ///pActiveObject: IOleInPlaceActiveObject*
    ///pszObjName: LPCOLESTR->OLECHAR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceFrameVtbl_SetActiveObject(ref IOleInPlaceFrame This,
        ref IOleInPlaceActiveObject pActiveObject, [In()]
        [MarshalAs(UnmanagedType.LPWStr)]
        string pszObjName);
}