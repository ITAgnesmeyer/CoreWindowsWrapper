using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IMoniker*
    ///pcbSize: ULARGE_INTEGER*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IMonikerVtbl_GetSizeMax(ref IMoniker This, ref ULARGE_INTEGER pcbSize);
}