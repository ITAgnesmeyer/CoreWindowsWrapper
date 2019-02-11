using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumFORMATETC*
    ///celt: ULONG->unsigned int
    ///rgelt: FORMATETC*
    ///pceltFetched: ULONG*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumFORMATETCVtbl_Next(ref IEnumFORMATETC This, uint celt, ref tagFORMATETC rgelt,
        ref uint pceltFetched);
}