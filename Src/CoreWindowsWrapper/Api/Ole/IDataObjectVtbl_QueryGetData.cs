using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IDataObject*
    ///pformatetc: FORMATETC*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IDataObjectVtbl_QueryGetData(ref IDataObject This, ref tagFORMATETC pformatetc);
}