using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleObject*
    ///dwWhichMoniker: DWORD->unsigned int
    ///pmk: IMoniker*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleObjectVtbl_SetMoniker(ref IOleObject This, uint dwWhichMoniker, ref IMoniker pmk);
}