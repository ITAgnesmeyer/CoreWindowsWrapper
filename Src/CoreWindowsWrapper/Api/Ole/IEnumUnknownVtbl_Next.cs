using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumUnknown*
    ///celt: ULONG->unsigned int
    ///rgelt: IUnknown**
    ///pceltFetched: ULONG*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumUnknownVtbl_Next(ref IEnumUnknown This, uint celt, ref IntPtr rgelt,
        ref uint pceltFetched);
}