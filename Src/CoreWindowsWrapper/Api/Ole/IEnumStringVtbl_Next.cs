using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumString*
    ///celt: ULONG->unsigned int
    ///rgelt: LPOLESTR*
    ///pceltFetched: ULONG*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumStringVtbl_Next(ref IEnumString This, uint celt, ref IntPtr rgelt,
        ref uint pceltFetched);
}