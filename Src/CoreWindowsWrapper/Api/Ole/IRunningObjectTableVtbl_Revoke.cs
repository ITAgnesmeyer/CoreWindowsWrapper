using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRunningObjectTable*
    ///dwRegister: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRunningObjectTableVtbl_Revoke(ref IRunningObjectTable This, uint dwRegister);
}