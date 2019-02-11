using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IMoniker*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IMonikerVtbl_Release(ref IMoniker This);
}