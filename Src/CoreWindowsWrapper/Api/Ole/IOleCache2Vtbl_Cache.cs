using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleCache2*
    ///pformatetc: FORMATETC*
    ///advf: DWORD->unsigned int
    ///pdwConnection: DWORD*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleCache2Vtbl_Cache(ref IOleCache2 This, ref tagFORMATETC pformatetc, uint advf,
        ref uint pdwConnection);
}