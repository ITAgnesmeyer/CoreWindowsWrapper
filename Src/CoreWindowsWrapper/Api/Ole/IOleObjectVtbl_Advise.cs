using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleObject*
    ///pAdvSink: IAdviseSink*
    ///pdwConnection: DWORD*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleObjectVtbl_Advise(ref IOleObject This, ref IAdviseSink pAdvSink, ref uint pdwConnection);
}