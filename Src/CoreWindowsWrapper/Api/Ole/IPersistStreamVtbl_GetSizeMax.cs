using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IPersistStream*
    ///pcbSize: ULARGE_INTEGER*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IPersistStreamVtbl_GetSizeMax(ref IPersistStream This, ref ULARGE_INTEGER pcbSize);
}