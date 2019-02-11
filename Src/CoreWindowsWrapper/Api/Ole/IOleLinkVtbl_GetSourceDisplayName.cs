using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleLink*
    ///ppszDisplayName: LPOLESTR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleLinkVtbl_GetSourceDisplayName(ref IOleLink This, ref IntPtr ppszDisplayName);
}