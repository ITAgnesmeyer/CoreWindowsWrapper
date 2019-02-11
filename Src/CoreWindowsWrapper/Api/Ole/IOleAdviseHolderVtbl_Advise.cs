using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleAdviseHolder*
    ///pAdvise: IAdviseSink*
    ///pdwConnection: DWORD*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleAdviseHolderVtbl_Advise(ref IOleAdviseHolder This, ref IAdviseSink pAdvise,
        ref uint pdwConnection);
}