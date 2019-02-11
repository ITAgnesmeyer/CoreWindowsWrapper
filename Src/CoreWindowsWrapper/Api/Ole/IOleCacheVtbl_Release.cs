using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IOleCache*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IOleCacheVtbl_Release(ref IOleCache This);
}