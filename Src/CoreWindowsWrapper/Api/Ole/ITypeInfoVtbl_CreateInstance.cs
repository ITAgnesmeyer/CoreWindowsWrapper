using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeInfo*
    ///pUnkOuter: IUnknown*
    ///riid: IID*
    ///ppvObj: PVOID*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeInfoVtbl_CreateInstance(ref ITypeInfo This, ref IUnknown pUnkOuter, ref GUID riid,
        ref IntPtr ppvObj);
}