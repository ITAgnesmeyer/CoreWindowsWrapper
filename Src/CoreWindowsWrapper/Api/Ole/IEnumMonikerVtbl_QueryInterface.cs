using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumMoniker*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumMonikerVtbl_QueryInterface(ref IEnumMoniker This, ref GUID riid,
        ref IntPtr ppvObject);
}