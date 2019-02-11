using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleCache2*
    ///dwConnection: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleCache2Vtbl_Uncache(ref IOleCache2 This, uint dwConnection);
}