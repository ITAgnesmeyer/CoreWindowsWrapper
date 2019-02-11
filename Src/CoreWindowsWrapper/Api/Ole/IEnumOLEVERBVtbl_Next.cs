using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumOLEVERB*
    ///celt: ULONG->unsigned int
    ///rgelt: LPOLEVERB->tagOLEVERB*
    ///pceltFetched: ULONG*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumOLEVERBVtbl_Next(ref IEnumOLEVERB This, uint celt, ref tagOLEVERB rgelt,
        ref uint pceltFetched);
}