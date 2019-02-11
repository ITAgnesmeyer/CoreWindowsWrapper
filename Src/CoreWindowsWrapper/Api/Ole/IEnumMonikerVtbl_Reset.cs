using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumMoniker*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumMonikerVtbl_Reset(ref IEnumMoniker This);
}