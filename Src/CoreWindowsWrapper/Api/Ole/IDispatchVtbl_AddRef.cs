using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IDispatch*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IDispatchVtbl_AddRef(ref IDispatch This);
}