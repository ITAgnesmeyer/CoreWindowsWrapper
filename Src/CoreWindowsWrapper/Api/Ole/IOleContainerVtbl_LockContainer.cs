using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleContainer*
    ///fLock: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleContainerVtbl_LockContainer(ref IOleContainer This,
        [MarshalAs(UnmanagedType.Bool)]
        bool fLock);
}