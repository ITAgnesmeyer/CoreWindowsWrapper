using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStream*
    ///libOffset: ULARGE_INTEGER->_ULARGE_INTEGER
    ///cb: ULARGE_INTEGER->_ULARGE_INTEGER
    ///dwLockType: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStreamVtbl_LockRegion(ref IStream This, ULARGE_INTEGER libOffset, ULARGE_INTEGER cb,
        uint dwLockType);
}