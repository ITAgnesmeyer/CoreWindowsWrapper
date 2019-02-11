using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeInfo*
    ///ppTLib: ITypeLib**
    ///pIndex: UINT*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeInfoVtbl_GetContainingTypeLib(ref ITypeInfo This, ref IntPtr ppTLib,
        ref uint pIndex);
}