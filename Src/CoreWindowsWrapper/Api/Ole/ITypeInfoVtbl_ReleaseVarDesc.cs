using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: void
    ///This: ITypeInfo*
    ///pVarDesc: VARDESC*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate void ITypeInfoVtbl_ReleaseVarDesc(ref ITypeInfo This, ref tagVARDESC pVarDesc);
}