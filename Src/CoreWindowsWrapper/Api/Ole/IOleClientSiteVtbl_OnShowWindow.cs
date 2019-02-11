using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleClientSite*
    ///fShow: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleClientSiteVtbl_OnShowWindow(ref IOleClientSite This,
        [MarshalAs(UnmanagedType.Bool)]
        bool fShow);
}