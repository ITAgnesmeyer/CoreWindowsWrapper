using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceActiveObject*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceActiveObjectVtbl_QueryInterface(ref IOleInPlaceActiveObject This, ref GUID riid,
        ref IntPtr ppvObject);
}