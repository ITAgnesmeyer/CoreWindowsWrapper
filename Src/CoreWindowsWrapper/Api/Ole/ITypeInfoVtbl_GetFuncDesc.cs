using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeInfo*
    ///index: UINT->unsigned int
    ///ppFuncDesc: FUNCDESC**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeInfoVtbl_GetFuncDesc(ref ITypeInfo This, uint index, ref IntPtr ppFuncDesc);
}