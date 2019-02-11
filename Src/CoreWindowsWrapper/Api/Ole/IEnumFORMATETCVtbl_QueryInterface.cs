using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumFORMATETC*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumFORMATETCVtbl_QueryInterface(ref IEnumFORMATETC This, ref GUID riid,
        ref IntPtr ppvObject);
}