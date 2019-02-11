using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRunningObjectTable*
    ///ppenumMoniker: IEnumMoniker**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRunningObjectTableVtbl_EnumRunning(ref IRunningObjectTable This,
        ref IntPtr ppenumMoniker);
}