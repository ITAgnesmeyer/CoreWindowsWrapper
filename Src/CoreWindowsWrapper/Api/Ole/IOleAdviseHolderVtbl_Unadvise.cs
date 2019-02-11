using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleAdviseHolder*
    ///dwConnection: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleAdviseHolderVtbl_Unadvise(ref IOleAdviseHolder This, uint dwConnection);
}