using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeLib*
    ///index: UINT->unsigned int
    ///ppTInfo: ITypeInfo**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeLibVtbl_GetTypeInfo(ref ITypeLib This, uint index, ref IntPtr ppTInfo);
}