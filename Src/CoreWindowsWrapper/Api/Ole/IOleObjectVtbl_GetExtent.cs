using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleObject*
    ///dwDrawAspect: DWORD->unsigned int
    ///psizel: SIZEL*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleObjectVtbl_GetExtent(ref IOleObject This, uint dwDrawAspect, ref tagSIZE psizel);
}