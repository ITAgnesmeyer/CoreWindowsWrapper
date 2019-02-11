using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStorage*
    ///pwcsName: OLECHAR*
    ///pstgPriority: IStorage*
    ///grfMode: DWORD->unsigned int
    ///snbExclude: SNB->OLECHAR**
    ///reserved: DWORD->unsigned int
    ///ppstg: IStorage**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStorageVtbl_OpenStorage(ref IStorage This,
        [In()]
        [MarshalAs(UnmanagedType.LPWStr)]
        string pwcsName, ref IStorage pstgPriority, uint grfMode, ref IntPtr snbExclude, uint reserved,
        ref IntPtr ppstg);
}