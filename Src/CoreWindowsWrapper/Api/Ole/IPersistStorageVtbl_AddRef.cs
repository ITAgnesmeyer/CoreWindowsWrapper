using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IPersistStorage*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IPersistStorageVtbl_AddRef(ref IPersistStorage This);
}