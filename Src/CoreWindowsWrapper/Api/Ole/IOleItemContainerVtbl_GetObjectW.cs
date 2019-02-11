using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleItemContainer*
    ///pszItem: LPOLESTR->OLECHAR*
    ///dwSpeedNeeded: DWORD->unsigned int
    ///pbc: IBindCtx*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleItemContainerVtbl_GetObjectW(ref IOleItemContainer This, IntPtr pszItem,
        uint dwSpeedNeeded, ref IBindCtx pbc, ref GUID riid, ref IntPtr ppvObject);
}