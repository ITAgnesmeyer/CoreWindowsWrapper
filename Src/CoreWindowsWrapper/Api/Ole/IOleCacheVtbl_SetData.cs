using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleCache*
    ///pformatetc: FORMATETC*
    ///pmedium: STGMEDIUM*
    ///fRelease: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleCacheVtbl_SetData(ref IOleCache This, ref tagFORMATETC pformatetc, ref tagSTGMEDIUM pmedium,
        [MarshalAs(UnmanagedType.Bool)]
        bool fRelease);
}