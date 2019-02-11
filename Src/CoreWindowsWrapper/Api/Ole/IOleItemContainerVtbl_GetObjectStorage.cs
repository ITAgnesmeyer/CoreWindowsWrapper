using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleItemContainer*
    ///pszItem: LPOLESTR->OLECHAR*
    ///pbc: IBindCtx*
    ///riid: IID*
    ///ppvStorage: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleItemContainerVtbl_GetObjectStorage(ref IOleItemContainer This, IntPtr pszItem,
        ref IBindCtx pbc, ref GUID riid, ref IntPtr ppvStorage);
}