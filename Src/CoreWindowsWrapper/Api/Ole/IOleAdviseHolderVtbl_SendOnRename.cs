using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleAdviseHolder*
    ///pmk: IMoniker*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleAdviseHolderVtbl_SendOnRename(ref IOleAdviseHolder This, ref IMoniker pmk);
}