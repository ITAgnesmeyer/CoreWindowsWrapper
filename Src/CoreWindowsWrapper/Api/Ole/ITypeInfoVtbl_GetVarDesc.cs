using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeInfo*
    ///index: UINT->unsigned int
    ///ppVarDesc: VARDESC**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeInfoVtbl_GetVarDesc(ref ITypeInfo This, uint index, ref IntPtr ppVarDesc);
}