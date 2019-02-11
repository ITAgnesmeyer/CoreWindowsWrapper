using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeLib*
    ///ppTComp: ITypeComp**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeLibVtbl_GetTypeComp(ref ITypeLib This, ref IntPtr ppTComp);
}