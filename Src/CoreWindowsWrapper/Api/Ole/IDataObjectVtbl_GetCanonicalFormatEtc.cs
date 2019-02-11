using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IDataObject*
    ///pformatectIn: FORMATETC*
    ///pformatetcOut: FORMATETC*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IDataObjectVtbl_GetCanonicalFormatEtc(ref IDataObject This, ref tagFORMATETC pformatectIn,
        ref tagFORMATETC pformatetcOut);
}