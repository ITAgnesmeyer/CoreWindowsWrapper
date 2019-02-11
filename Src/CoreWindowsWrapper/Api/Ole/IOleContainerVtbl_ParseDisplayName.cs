using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleContainer*
    ///pbc: IBindCtx*
    ///pszDisplayName: LPOLESTR->OLECHAR*
    ///pchEaten: ULONG*
    ///ppmkOut: IMoniker**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleContainerVtbl_ParseDisplayName(ref IOleContainer This, ref IBindCtx pbc,
        IntPtr pszDisplayName, ref uint pchEaten, ref IntPtr ppmkOut);
}