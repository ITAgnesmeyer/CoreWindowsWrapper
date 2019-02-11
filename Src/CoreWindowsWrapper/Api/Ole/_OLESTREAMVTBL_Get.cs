using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: DWORD->unsigned int
    ///param0: LPOLESTREAM->_OLESTREAM*
    ///param1: void*
    ///param2: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint _OLESTREAMVTBL_Get(ref OLESTREAM param0, IntPtr param1, uint param2);
}