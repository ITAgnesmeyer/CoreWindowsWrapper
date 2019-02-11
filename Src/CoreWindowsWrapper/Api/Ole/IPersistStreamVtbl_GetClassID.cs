using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IPersistStream*
    ///pClassID: CLSID*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IPersistStreamVtbl_GetClassID(ref IPersistStream This, ref GUID pClassID);
}