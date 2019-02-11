using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumSTATSTG*
    ///ppenum: IEnumSTATSTG**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumSTATSTGVtbl_Clone(ref IEnumSTATSTG This, ref IntPtr ppenum);
}