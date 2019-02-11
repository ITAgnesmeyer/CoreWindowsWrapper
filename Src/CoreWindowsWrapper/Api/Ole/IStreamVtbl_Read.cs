using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStream*
    ///pv: void*
    ///cb: ULONG->unsigned int
    ///pcbRead: ULONG*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStreamVtbl_Read(ref IStream This, IntPtr pv, uint cb, ref uint pcbRead);
}