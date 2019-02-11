using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IEnumSTATDATA*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IEnumSTATDATAVtbl_AddRef(ref IEnumSTATDATA This);
}