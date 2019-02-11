using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IUnknown*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IUnknownVtbl_AddRef(ref IUnknown This);
}