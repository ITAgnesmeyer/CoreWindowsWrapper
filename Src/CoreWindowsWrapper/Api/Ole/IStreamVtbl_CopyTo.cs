using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStream*
    ///pstm: IStream*
    ///cb: ULARGE_INTEGER->_ULARGE_INTEGER
    ///pcbRead: ULARGE_INTEGER*
    ///pcbWritten: ULARGE_INTEGER*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStreamVtbl_CopyTo(ref IStream This, ref IStream pstm, ULARGE_INTEGER cb,
        ref ULARGE_INTEGER pcbRead, ref ULARGE_INTEGER pcbWritten);
}