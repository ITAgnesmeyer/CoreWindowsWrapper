using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeLib*
    ///szNameBuf: LPOLESTR->OLECHAR*
    ///lHashVal: ULONG->unsigned int
    ///ppTInfo: ITypeInfo**
    ///rgMemId: MEMBERID*
    ///pcFound: USHORT*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeLibVtbl_FindName(ref ITypeLib This, IntPtr szNameBuf, uint lHashVal,
        ref IntPtr ppTInfo, ref int rgMemId, ref ushort pcFound);
}