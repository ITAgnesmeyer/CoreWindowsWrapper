using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumSTATSTG*
    ///celt: ULONG->unsigned int
    ///rgelt: STATSTG*
    ///pceltFetched: ULONG*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumSTATSTGVtbl_Next(ref IEnumSTATSTG This, uint celt, ref tagSTATSTG rgelt,
        ref uint pceltFetched);
}