using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRunningObjectTable*
    ///pmkObjectName: IMoniker*
    ///pfiletime: FILETIME*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRunningObjectTableVtbl_GetTimeOfLastChange(ref IRunningObjectTable This,
        ref IMoniker pmkObjectName, ref FILETIME pfiletime);
}