using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IStorage*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IStorageVtbl_AddRef(ref IStorage This);
}