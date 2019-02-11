using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IOleCacheControl*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IOleCacheControlVtbl_Release(ref IOleCacheControl This);
}