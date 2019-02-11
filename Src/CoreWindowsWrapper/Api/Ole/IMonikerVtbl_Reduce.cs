using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IMoniker*
    ///pbc: IBindCtx*
    ///dwReduceHowFar: DWORD->unsigned int
    ///ppmkToLeft: IMoniker**
    ///ppmkReduced: IMoniker**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IMonikerVtbl_Reduce(ref IMoniker This, ref IBindCtx pbc, uint dwReduceHowFar,
        ref IntPtr ppmkToLeft, ref IntPtr ppmkReduced);
}