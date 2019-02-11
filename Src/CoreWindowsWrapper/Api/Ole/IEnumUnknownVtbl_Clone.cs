using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumUnknown*
    ///ppenum: IEnumUnknown**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumUnknownVtbl_Clone(ref IEnumUnknown This, ref IntPtr ppenum);
}