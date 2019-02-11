using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumUnknown*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumUnknownVtbl_Reset(ref IEnumUnknown This);
}