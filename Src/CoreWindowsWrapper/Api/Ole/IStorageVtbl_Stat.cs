using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStorage*
    ///pstatstg: STATSTG*
    ///grfStatFlag: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStorageVtbl_Stat(ref IStorage This, ref tagSTATSTG pstatstg, uint grfStatFlag);
}