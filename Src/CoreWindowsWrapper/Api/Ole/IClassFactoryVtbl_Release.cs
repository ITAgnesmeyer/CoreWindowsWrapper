using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IClassFactory*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IClassFactoryVtbl_Release(ref IClassFactory This);
}