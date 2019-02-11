using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IOleItemContainer*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IOleItemContainerVtbl_AddRef(ref IOleItemContainer This);
}