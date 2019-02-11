using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleItemContainer*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleItemContainerVtbl_QueryInterface(ref IOleItemContainer This, ref GUID riid,
        ref IntPtr ppvObject);
}