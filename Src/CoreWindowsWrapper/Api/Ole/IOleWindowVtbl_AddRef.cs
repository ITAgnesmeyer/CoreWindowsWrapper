using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IOleWindow*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IOleWindowVtbl_AddRef(ref IOleWindow This);
}