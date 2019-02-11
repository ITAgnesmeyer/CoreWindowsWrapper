using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStream*
    ///ppstm: IStream**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStreamVtbl_Clone(ref IStream This, ref IntPtr ppstm);
}