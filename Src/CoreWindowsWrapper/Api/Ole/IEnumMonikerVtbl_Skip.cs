using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumMoniker*
    ///celt: ULONG->unsigned int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumMonikerVtbl_Skip(ref IEnumMoniker This, uint celt);
}