using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumMoniker*
    ///celt: ULONG->unsigned int
    ///rgelt: IMoniker**
    ///pceltFetched: ULONG*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumMonikerVtbl_Next(ref IEnumMoniker This, uint celt, ref IntPtr rgelt,
        ref uint pceltFetched);
}