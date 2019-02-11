using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleObject*
    ///dwReserved: DWORD->unsigned int
    ///ppDataObject: IDataObject**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleObjectVtbl_GetClipboardData(ref IOleObject This, uint dwReserved,
        ref IntPtr ppDataObject);
}