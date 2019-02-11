using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IDataObject*
    ///pformatetc: FORMATETC*
    ///pmedium: STGMEDIUM*
    ///fRelease: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IDataObjectVtbl_SetData(ref IDataObject This, ref tagFORMATETC pformatetc,
        ref tagSTGMEDIUM pmedium,
        [MarshalAs(UnmanagedType.Bool)]
        bool fRelease);
}