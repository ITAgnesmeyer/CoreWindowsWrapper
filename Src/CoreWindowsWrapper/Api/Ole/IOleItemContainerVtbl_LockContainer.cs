using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleItemContainer*
    ///fLock: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleItemContainerVtbl_LockContainer(ref IOleItemContainer This,
        [MarshalAs(UnmanagedType.Bool)]
        bool fLock);
}