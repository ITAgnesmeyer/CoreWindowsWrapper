using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: ITypeInfo*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint ITypeInfoVtbl_Release(ref ITypeInfo This);
}