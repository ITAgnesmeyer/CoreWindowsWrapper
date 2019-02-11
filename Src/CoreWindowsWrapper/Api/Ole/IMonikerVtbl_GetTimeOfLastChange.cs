using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IMoniker*
    ///pbc: IBindCtx*
    ///pmkToLeft: IMoniker*
    ///pFileTime: FILETIME*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IMonikerVtbl_GetTimeOfLastChange(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft,
        ref FILETIME pFileTime);
}