using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IMoniker*
    ///pbc: IBindCtx*
    ///pmkToLeft: IMoniker*
    ///riid: IID*
    ///ppvObj: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IMonikerVtbl_BindToStorage(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft,
        ref GUID riid, ref IntPtr ppvObj);
}