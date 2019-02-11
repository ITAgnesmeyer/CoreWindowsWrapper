using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IDataObject*
    ///ppenumAdvise: IEnumSTATDATA**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IDataObjectVtbl_EnumDAdvise(ref IDataObject This, ref IntPtr ppenumAdvise);
}