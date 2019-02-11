using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: ITypeComp*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint ITypeCompVtbl_AddRef(ref ITypeComp This);
}