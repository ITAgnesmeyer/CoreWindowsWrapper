using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IDataObject*
    ///pformatetcIn: FORMATETC*
    ///pmedium: STGMEDIUM*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IDataObjectVtbl_GetData(ref IDataObject This, ref tagFORMATETC pformatetcIn,
        ref tagSTGMEDIUM pmedium);
}