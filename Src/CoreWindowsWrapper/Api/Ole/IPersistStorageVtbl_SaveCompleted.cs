using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IPersistStorage*
    ///pStgNew: IStorage*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IPersistStorageVtbl_SaveCompleted(ref IPersistStorage This, ref IStorage pStgNew);
}