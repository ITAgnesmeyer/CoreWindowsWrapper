using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleCache*
    ///ppenumSTATDATA: IEnumSTATDATA**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleCacheVtbl_EnumCache(ref IOleCache This, ref IntPtr ppenumSTATDATA);
}