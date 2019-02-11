using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IPersistStorage*
    ///pClassID: CLSID*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IPersistStorageVtbl_GetClassID(ref IPersistStorage This, ref GUID pClassID);
}