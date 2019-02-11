using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IRecordInfo*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IRecordInfoVtbl_Release(ref IRecordInfo This);
}