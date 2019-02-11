using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IDispatch*
    ///iTInfo: UINT->unsigned int
    ///lcid: LCID->DWORD->unsigned int
    ///ppTInfo: ITypeInfo**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int
        IDispatchVtbl_GetTypeInfo(ref IDispatch This, uint iTInfo, uint lcid, ref IntPtr ppTInfo);
}