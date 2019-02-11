using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IBindCtx*
    ///ppenum: IEnumString**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IBindCtxVtbl_EnumObjectParam(ref IBindCtx This, ref IntPtr ppenum);
}