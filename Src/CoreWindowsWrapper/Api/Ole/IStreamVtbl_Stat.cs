using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStream*
    ///pstatstg: STATSTG*
    ///grfStatFlag: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStreamVtbl_Stat(ref IStream This, ref tagSTATSTG pstatstg, uint grfStatFlag);
}