using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumSTATDATA*
    ///ppenum: IEnumSTATDATA**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumSTATDATAVtbl_Clone(ref IEnumSTATDATA This, ref IntPtr ppenum);
}