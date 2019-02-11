using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStorage*
    ///pwcsName: OLECHAR*
    ///grfMode: DWORD->unsigned int
    ///reserved1: DWORD->unsigned int
    ///reserved2: DWORD->unsigned int
    ///ppstg: IStorage**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStorageVtbl_CreateStorage(ref IStorage This,
        [In()]
        [MarshalAs(UnmanagedType.LPWStr)]
        string pwcsName, uint grfMode, uint reserved1, uint reserved2, ref IntPtr ppstg);
}