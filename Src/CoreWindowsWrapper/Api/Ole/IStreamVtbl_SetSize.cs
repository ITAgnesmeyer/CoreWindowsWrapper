using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStream*
    ///libNewSize: ULARGE_INTEGER->_ULARGE_INTEGER
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStreamVtbl_SetSize(ref IStream This, ULARGE_INTEGER libNewSize);
}