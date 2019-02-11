using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStorage*
    ///pwcsName: OLECHAR*
    ///pstgDest: IStorage*
    ///pwcsNewName: OLECHAR*
    ///grfFlags: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStorageVtbl_MoveElementTo(ref IStorage This,
        [In()]
        [MarshalAs(UnmanagedType.LPWStr)]
        string pwcsName, ref IStorage pstgDest, [In()]
        [MarshalAs(UnmanagedType.LPWStr)]
        string pwcsNewName, uint grfFlags);
}