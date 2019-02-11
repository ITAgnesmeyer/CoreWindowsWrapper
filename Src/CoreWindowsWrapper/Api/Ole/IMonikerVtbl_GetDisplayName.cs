using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IMoniker*
    ///pbc: IBindCtx*
    ///pmkToLeft: IMoniker*
    ///ppszDisplayName: LPOLESTR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IMonikerVtbl_GetDisplayName(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft,
        ref IntPtr ppszDisplayName);
}