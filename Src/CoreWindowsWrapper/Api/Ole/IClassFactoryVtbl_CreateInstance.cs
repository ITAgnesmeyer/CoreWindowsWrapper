using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IClassFactory*
    ///pUnkOuter: IUnknown*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IClassFactoryVtbl_CreateInstance(ref IClassFactory This, ref IUnknown pUnkOuter, ref GUID riid,
        ref IntPtr ppvObject);
}