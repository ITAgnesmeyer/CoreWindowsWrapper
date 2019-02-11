using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStorage*
    ///pwcsName: OLECHAR*
    ///reserved1: void*
    ///grfMode: DWORD->unsigned int
    ///reserved2: DWORD->unsigned int
    ///ppstm: IStream**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStorageVtbl_OpenStream(ref IStorage This,
        [In()]
        [MarshalAs(UnmanagedType.LPWStr)]
        string pwcsName, IntPtr reserved1, uint grfMode, uint reserved2, ref IntPtr ppstm);
}