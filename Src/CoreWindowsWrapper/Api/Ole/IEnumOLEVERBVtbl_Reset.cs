using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumOLEVERB*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumOLEVERBVtbl_Reset(ref IEnumOLEVERB This);
}