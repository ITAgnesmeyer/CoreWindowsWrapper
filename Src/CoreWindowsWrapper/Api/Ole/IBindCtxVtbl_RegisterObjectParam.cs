using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IBindCtx*
    ///pszKey: LPOLESTR->OLECHAR*
    ///punk: IUnknown*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IBindCtxVtbl_RegisterObjectParam(ref IBindCtx This, IntPtr pszKey, ref IUnknown punk);
}