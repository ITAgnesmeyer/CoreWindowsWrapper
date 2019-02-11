using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: void
    ///This: ITypeInfo*
    ///pFuncDesc: FUNCDESC*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate void ITypeInfoVtbl_ReleaseFuncDesc(ref ITypeInfo This, ref tagFUNCDESC pFuncDesc);
}