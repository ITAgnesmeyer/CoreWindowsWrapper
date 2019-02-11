using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleClientSite*
    ///dwAssign: DWORD->unsigned int
    ///dwWhichMoniker: DWORD->unsigned int
    ///ppmk: IMoniker**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleClientSiteVtbl_GetMoniker(ref IOleClientSite This, uint dwAssign, uint dwWhichMoniker,
        ref IntPtr ppmk);
}