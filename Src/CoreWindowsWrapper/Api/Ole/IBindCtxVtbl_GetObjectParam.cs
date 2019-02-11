using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IBindCtx*
    ///pszKey: LPOLESTR->OLECHAR*
    ///ppunk: IUnknown**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IBindCtxVtbl_GetObjectParam(ref IBindCtx This, IntPtr pszKey, ref IntPtr ppunk);
}