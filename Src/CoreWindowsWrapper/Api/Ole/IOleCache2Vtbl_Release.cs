using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IOleCache2*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IOleCache2Vtbl_Release(ref IOleCache2 This);
}