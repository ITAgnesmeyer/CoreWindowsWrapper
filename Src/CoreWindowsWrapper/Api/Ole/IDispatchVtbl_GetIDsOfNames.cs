using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IDispatch*
    ///riid: IID*
    ///rgszNames: LPOLESTR*
    ///cNames: UINT->unsigned int
    ///lcid: LCID->DWORD->unsigned int
    ///rgDispId: DISPID*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IDispatchVtbl_GetIDsOfNames(ref IDispatch This, ref GUID riid, ref IntPtr rgszNames,
        uint cNames, uint lcid, ref int rgDispId);
}