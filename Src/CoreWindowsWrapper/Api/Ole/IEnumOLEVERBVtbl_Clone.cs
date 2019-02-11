using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumOLEVERB*
    ///ppenum: IEnumOLEVERB**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumOLEVERBVtbl_Clone(ref IEnumOLEVERB This, ref IntPtr ppenum);
}