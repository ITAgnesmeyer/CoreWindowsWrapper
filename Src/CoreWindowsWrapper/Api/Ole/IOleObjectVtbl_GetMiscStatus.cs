using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleObject*
    ///dwAspect: DWORD->unsigned int
    ///pdwStatus: DWORD*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleObjectVtbl_GetMiscStatus(ref IOleObject This, uint dwAspect, ref uint pdwStatus);
}