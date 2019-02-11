using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumString*
    ///ppenum: IEnumString**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumStringVtbl_Clone(ref IEnumString This, ref IntPtr ppenum);
}