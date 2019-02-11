using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRunningObjectTable*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRunningObjectTableVtbl_QueryInterface(ref IRunningObjectTable This, ref GUID riid,
        ref IntPtr ppvObject);
}