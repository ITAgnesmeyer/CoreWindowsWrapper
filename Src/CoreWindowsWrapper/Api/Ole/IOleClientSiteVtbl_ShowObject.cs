using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleClientSite*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleClientSiteVtbl_ShowObject(ref IOleClientSite This);
}