using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleClientSite*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleClientSiteVtbl_QueryInterface(ref IOleClientSite This, ref GUID riid,
        ref IntPtr ppvObject);
}