using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStorage*
    ///reserved1: DWORD->unsigned int
    ///reserved2: void*
    ///reserved3: DWORD->unsigned int
    ///ppenum: IEnumSTATSTG**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStorageVtbl_EnumElements(ref IStorage This, uint reserved1, IntPtr reserved2,
        uint reserved3, ref IntPtr ppenum);
}