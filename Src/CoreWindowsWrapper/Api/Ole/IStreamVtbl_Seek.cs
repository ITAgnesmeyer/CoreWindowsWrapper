using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStream*
    ///dlibMove: LARGE_INTEGER->_LARGE_INTEGER
    ///dwOrigin: DWORD->unsigned int
    ///plibNewPosition: ULARGE_INTEGER*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStreamVtbl_Seek(ref IStream This, LARGE_INTEGER dlibMove, uint dwOrigin,
        ref ULARGE_INTEGER plibNewPosition);
}