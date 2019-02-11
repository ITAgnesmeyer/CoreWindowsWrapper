using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleObject*
    ///dwAssign: DWORD->unsigned int
    ///dwWhichMoniker: DWORD->unsigned int
    ///ppmk: IMoniker**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleObjectVtbl_GetMoniker(ref IOleObject This, uint dwAssign, uint dwWhichMoniker,
        ref IntPtr ppmk);
}