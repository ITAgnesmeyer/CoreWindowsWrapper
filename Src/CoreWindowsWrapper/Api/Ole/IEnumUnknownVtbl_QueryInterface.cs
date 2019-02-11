using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumUnknown*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumUnknownVtbl_QueryInterface(ref IEnumUnknown This, ref GUID riid,
        ref IntPtr ppvObject);
}