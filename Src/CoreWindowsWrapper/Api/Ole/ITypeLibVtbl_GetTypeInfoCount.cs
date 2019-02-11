using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: UINT->unsigned int
    ///This: ITypeLib*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint ITypeLibVtbl_GetTypeInfoCount(ref ITypeLib This);
}