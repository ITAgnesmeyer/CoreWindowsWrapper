using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleLink*
    ///ppunk: IUnknown**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleLinkVtbl_GetBoundSource(ref IOleLink This, ref IntPtr ppunk);
}