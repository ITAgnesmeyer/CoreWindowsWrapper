using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRunningObjectTable*
    ///pmkObjectName: IMoniker*
    ///ppunkObject: IUnknown**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRunningObjectTableVtbl_GetObjectW(ref IRunningObjectTable This, ref IMoniker pmkObjectName,
        ref IntPtr ppunkObject);
}