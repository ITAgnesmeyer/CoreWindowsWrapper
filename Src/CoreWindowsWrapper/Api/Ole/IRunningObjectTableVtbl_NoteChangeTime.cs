using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRunningObjectTable*
    ///dwRegister: DWORD->unsigned int
    ///pfiletime: FILETIME*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRunningObjectTableVtbl_NoteChangeTime(ref IRunningObjectTable This, uint dwRegister,
        ref FILETIME pfiletime);
}