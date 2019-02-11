using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumOLEVERB*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumOLEVERBVtbl_QueryInterface(ref IEnumOLEVERB This, ref GUID riid,
        ref IntPtr ppvObject);
}