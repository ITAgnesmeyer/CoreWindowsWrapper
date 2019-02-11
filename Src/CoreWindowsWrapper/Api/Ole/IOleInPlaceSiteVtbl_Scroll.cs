using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceSite*
    ///scrollExtant: SIZE->tagSIZE
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceSiteVtbl_Scroll(ref IOleInPlaceSite This, tagSIZE scrollExtant);
}