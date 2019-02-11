using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IOleClientSite*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IOleClientSiteVtbl_AddRef(ref IOleClientSite This);
}