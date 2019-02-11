using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeLib*
    ///guid: GUID*
    ///ppTinfo: ITypeInfo**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeLibVtbl_GetTypeInfoOfGuid(ref ITypeLib This, ref GUID guid, ref IntPtr ppTinfo);
}