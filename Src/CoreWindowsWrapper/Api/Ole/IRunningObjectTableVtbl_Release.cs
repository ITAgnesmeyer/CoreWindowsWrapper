using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IRunningObjectTable*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IRunningObjectTableVtbl_Release(ref IRunningObjectTable This);
}