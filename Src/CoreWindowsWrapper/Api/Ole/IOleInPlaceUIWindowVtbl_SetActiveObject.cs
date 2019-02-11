using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceUIWindow*
    ///pActiveObject: IOleInPlaceActiveObject*
    ///pszObjName: LPCOLESTR->OLECHAR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceUIWindowVtbl_SetActiveObject(ref IOleInPlaceUIWindow This,
        ref IOleInPlaceActiveObject pActiveObject, [In()]
        [MarshalAs(UnmanagedType.LPWStr)]
        string pszObjName);
}