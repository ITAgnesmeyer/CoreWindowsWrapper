using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeLib*
    ///szNameBuf: LPOLESTR->OLECHAR*
    ///lHashVal: ULONG->unsigned int
    ///pfName: BOOL*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeLibVtbl_IsName(ref ITypeLib This, IntPtr szNameBuf, uint lHashVal, ref int pfName);
}