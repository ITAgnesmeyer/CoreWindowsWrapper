using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumOLEVERB*
    ///celt: ULONG->unsigned int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumOLEVERBVtbl_Skip(ref IEnumOLEVERB This, uint celt);
}