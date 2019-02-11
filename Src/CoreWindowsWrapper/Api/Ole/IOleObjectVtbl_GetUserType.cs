using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleObject*
    ///dwFormOfType: DWORD->unsigned int
    ///pszUserType: LPOLESTR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleObjectVtbl_GetUserType(ref IOleObject This, uint dwFormOfType,
        ref IntPtr pszUserType);
}