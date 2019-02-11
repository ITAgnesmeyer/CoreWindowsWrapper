using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: void
    ///This: IAdviseSink*
    ///pFormatetc: FORMATETC*
    ///pStgmed: STGMEDIUM*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate void IAdviseSinkVtbl_OnDataChange(ref IAdviseSink This, ref tagFORMATETC pFormatetc,
        ref tagSTGMEDIUM pStgmed);
}