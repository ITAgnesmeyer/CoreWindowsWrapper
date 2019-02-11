using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleLink*
    ///pszStatusText: LPCOLESTR->OLECHAR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleLinkVtbl_SetSourceDisplayName(ref IOleLink This,
        [In()]
        [MarshalAs(UnmanagedType.LPWStr)]
        string pszStatusText);
}