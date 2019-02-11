using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IMoniker*
    ///pbc: IBindCtx*
    ///pmkToLeft: IMoniker*
    ///pszDisplayName: LPOLESTR->OLECHAR*
    ///pchEaten: ULONG*
    ///ppmkOut: IMoniker**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IMonikerVtbl_ParseDisplayName(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft,
        IntPtr pszDisplayName, ref uint pchEaten, ref IntPtr ppmkOut);
}