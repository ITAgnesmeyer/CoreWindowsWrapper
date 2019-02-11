using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeInfo*
    ///ppTComp: ITypeComp**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeInfoVtbl_GetTypeComp(ref ITypeInfo This, ref IntPtr ppTComp);
}