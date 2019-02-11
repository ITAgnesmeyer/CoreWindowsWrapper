using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IClassFactory*
    ///fLock: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IClassFactoryVtbl_LockServer(ref IClassFactory This,
        [MarshalAs(UnmanagedType.Bool)]
        bool fLock);
}