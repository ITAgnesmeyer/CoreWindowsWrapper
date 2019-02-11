using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleAdviseHolder*
    ///ppenumAdvise: IEnumSTATDATA**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleAdviseHolderVtbl_EnumAdvise(ref IOleAdviseHolder This, ref IntPtr ppenumAdvise);
}