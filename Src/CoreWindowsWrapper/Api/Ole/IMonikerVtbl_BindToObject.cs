using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IMoniker*
    ///pbc: IBindCtx*
    ///pmkToLeft: IMoniker*
    ///riidResult: IID*
    ///ppvResult: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IMonikerVtbl_BindToObject(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft,
        ref GUID riidResult, ref IntPtr ppvResult);
}