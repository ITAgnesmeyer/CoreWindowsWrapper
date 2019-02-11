using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IDataObject*
    ///pformatetc: FORMATETC*
    ///pmedium: STGMEDIUM*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IDataObjectVtbl_GetDataHere(ref IDataObject This, ref tagFORMATETC pformatetc,
        ref tagSTGMEDIUM pmedium);
}