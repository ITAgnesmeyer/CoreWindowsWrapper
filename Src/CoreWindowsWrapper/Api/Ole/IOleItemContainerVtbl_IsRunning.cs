using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleItemContainer*
    ///pszItem: LPOLESTR->OLECHAR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleItemContainerVtbl_IsRunning(ref IOleItemContainer This, IntPtr pszItem);
}