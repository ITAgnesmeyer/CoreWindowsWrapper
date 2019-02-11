using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleObject*
    ///pLogpal: LOGPALETTE*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleObjectVtbl_SetColorScheme(ref IOleObject This, ref tagLOGPALETTE pLogpal);
}