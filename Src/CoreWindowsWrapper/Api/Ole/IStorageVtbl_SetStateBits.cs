using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStorage*
    ///grfStateBits: DWORD->unsigned int
    ///grfMask: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStorageVtbl_SetStateBits(ref IStorage This, uint grfStateBits, uint grfMask);
}