using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IMoniker*
    ///fForward: BOOL->int
    ///ppenumMoniker: IEnumMoniker**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IMonikerVtbl_Enum(ref IMoniker This,
        [MarshalAs(UnmanagedType.Bool)]
        bool fForward, ref IntPtr ppenumMoniker);
}