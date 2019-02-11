using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleObject*
    ///pClientSite: IOleClientSite*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleObjectVtbl_SetClientSite(ref IOleObject This, ref IOleClientSite pClientSite);
}