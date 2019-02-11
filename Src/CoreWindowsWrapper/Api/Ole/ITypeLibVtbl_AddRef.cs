using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: ITypeLib*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint ITypeLibVtbl_AddRef(ref ITypeLib This);
}