using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleItemContainer*
    ///pbc: IBindCtx*
    ///pszDisplayName: LPOLESTR->OLECHAR*
    ///pchEaten: ULONG*
    ///ppmkOut: IMoniker**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleItemContainerVtbl_ParseDisplayName(ref IOleItemContainer This, ref IBindCtx pbc,
        IntPtr pszDisplayName, ref uint pchEaten, ref IntPtr ppmkOut);
}