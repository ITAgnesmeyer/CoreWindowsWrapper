using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleObject*
    ///pClsid: CLSID*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleObjectVtbl_GetUserClassID(ref IOleObject This, ref GUID pClsid);
}