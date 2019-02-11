using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IOleLink*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IOleLinkVtbl_AddRef(ref IOleLink This);
}