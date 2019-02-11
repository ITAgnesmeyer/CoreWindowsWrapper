using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumSTATDATA*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumSTATDATAVtbl_Reset(ref IEnumSTATDATA This);
}