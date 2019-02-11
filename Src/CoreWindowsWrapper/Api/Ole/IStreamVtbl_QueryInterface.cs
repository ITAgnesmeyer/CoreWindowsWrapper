using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStream*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStreamVtbl_QueryInterface(ref IStream This, ref GUID riid, ref IntPtr ppvObject);
}