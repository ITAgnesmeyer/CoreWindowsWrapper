using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IBindCtx*
    ///pprot: IRunningObjectTable**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IBindCtxVtbl_GetRunningObjectTable(ref IBindCtx This, ref IntPtr pprot);
}