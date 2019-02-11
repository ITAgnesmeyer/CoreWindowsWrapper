using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IPersistStream*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IPersistStreamVtbl_Release(ref IPersistStream This);
}