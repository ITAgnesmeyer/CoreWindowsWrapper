using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IEnumSTATSTG*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IEnumSTATSTGVtbl_AddRef(ref IEnumSTATSTG This);
}