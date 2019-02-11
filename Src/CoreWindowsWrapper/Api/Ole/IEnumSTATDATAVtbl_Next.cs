using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumSTATDATA*
    ///celt: ULONG->unsigned int
    ///rgelt: STATDATA*
    ///pceltFetched: ULONG*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumSTATDATAVtbl_Next(ref IEnumSTATDATA This, uint celt, ref tagSTATDATA rgelt,
        ref uint pceltFetched);
}