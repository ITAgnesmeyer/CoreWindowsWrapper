using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IMoniker*
    ///pbc: IBindCtx*
    ///pmkToLeft: IMoniker*
    ///pmkNewlyRunning: IMoniker*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IMonikerVtbl_IsRunning(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft,
        ref IMoniker pmkNewlyRunning);
}