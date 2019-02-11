using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IOleContainer*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IOleContainerVtbl_AddRef(ref IOleContainer This);
}