using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IStream*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IStreamVtbl_Release(ref IStream This);
}