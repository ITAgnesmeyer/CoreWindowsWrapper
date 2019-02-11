using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleCache2*
    ///pformatetc: FORMATETC*
    ///pmedium: STGMEDIUM*
    ///fRelease: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleCache2Vtbl_SetData(ref IOleCache2 This, ref tagFORMATETC pformatetc,
        ref tagSTGMEDIUM pmedium,
        [MarshalAs(UnmanagedType.Bool)]
        bool fRelease);
}