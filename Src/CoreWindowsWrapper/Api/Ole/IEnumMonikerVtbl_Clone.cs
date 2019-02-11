using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumMoniker*
    ///ppenum: IEnumMoniker**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumMonikerVtbl_Clone(ref IEnumMoniker This, ref IntPtr ppenum);
}