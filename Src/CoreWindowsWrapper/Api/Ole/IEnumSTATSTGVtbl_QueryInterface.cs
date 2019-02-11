using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumSTATSTG*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumSTATSTGVtbl_QueryInterface(ref IEnumSTATSTG This, ref GUID riid,
        ref IntPtr ppvObject);
}