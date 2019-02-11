using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRunningObjectTable*
    ///pmkObjectName: IMoniker*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRunningObjectTableVtbl_IsRunning(ref IRunningObjectTable This, ref IMoniker pmkObjectName);
}