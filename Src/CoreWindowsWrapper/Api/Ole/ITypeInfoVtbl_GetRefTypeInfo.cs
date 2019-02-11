using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeInfo*
    ///hRefType: HREFTYPE->DWORD->unsigned int
    ///ppTInfo: ITypeInfo**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeInfoVtbl_GetRefTypeInfo(ref ITypeInfo This, uint hRefType, ref IntPtr ppTInfo);
}