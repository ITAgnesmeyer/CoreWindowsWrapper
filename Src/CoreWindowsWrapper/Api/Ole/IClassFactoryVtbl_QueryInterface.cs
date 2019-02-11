using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IClassFactory*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IClassFactoryVtbl_QueryInterface(ref IClassFactory This, ref GUID riid,
        ref IntPtr ppvObject);
}