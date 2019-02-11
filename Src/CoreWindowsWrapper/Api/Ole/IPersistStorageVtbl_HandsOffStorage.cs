using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IPersistStorage*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IPersistStorageVtbl_HandsOffStorage(ref IPersistStorage This);
}