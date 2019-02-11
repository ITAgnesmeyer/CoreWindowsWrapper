using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleObject*
    ///szContainerApp: LPCOLESTR->OLECHAR*
    ///szContainerObj: LPCOLESTR->OLECHAR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleObjectVtbl_SetHostNames(ref IOleObject This,
        [In()]
        [MarshalAs(UnmanagedType.LPWStr)]
        string szContainerApp, [In()]
        [MarshalAs(UnmanagedType.LPWStr)]
        string szContainerObj);
}