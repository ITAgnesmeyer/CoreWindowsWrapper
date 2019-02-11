using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IDataObject*
    ///pformatetc: FORMATETC*
    ///advf: DWORD->unsigned int
    ///pAdvSink: IAdviseSink*
    ///pdwConnection: DWORD*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IDataObjectVtbl_DAdvise(ref IDataObject This, ref tagFORMATETC pformatetc, uint advf,
        ref IAdviseSink pAdvSink, ref uint pdwConnection);
}