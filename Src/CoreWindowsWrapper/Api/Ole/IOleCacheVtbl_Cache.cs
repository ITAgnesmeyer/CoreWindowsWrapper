using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleCache*
    ///pformatetc: FORMATETC*
    ///advf: DWORD->unsigned int
    ///pdwConnection: DWORD*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleCacheVtbl_Cache(ref IOleCache This, ref tagFORMATETC pformatetc, uint advf,
        ref uint pdwConnection);
}