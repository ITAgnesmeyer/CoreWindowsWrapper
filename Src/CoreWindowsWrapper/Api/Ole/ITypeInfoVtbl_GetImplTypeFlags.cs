using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeInfo*
    ///index: UINT->unsigned int
    ///pImplTypeFlags: INT*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeInfoVtbl_GetImplTypeFlags(ref ITypeInfo This, uint index, ref int pImplTypeFlags);
}