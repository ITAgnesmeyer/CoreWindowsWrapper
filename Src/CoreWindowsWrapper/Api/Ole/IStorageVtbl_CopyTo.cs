using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStorage*
    ///ciidExclude: DWORD->unsigned int
    ///rgiidExclude: IID*
    ///snbExclude: SNB->OLECHAR**
    ///pstgDest: IStorage*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStorageVtbl_CopyTo(ref IStorage This, uint ciidExclude, ref GUID rgiidExclude,
        ref IntPtr snbExclude, ref IStorage pstgDest);
}