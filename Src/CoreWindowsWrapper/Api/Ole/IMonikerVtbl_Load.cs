using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IMoniker*
    ///pStm: IStream*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IMonikerVtbl_Load(ref IMoniker This, ref IStream pStm);
}