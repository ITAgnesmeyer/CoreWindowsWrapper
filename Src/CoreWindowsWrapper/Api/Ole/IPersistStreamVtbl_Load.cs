using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IPersistStream*
    ///pStm: IStream*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IPersistStreamVtbl_Load(ref IPersistStream This, ref IStream pStm);
}