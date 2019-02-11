using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IOleAdviseHolder*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IOleAdviseHolderVtbl_Release(ref IOleAdviseHolder This);
}