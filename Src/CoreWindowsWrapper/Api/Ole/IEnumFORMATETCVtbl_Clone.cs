using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumFORMATETC*
    ///ppenum: IEnumFORMATETC**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumFORMATETCVtbl_Clone(ref IEnumFORMATETC This, ref IntPtr ppenum);
}