using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumString*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumStringVtbl_Reset(ref IEnumString This);
}