using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IOleObject*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IOleObjectVtbl_Release(ref IOleObject This);
}