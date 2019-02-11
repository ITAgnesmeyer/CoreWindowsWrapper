using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleAdviseHolder*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleAdviseHolderVtbl_QueryInterface(ref IOleAdviseHolder This, ref GUID riid,
        ref IntPtr ppvObject);
}