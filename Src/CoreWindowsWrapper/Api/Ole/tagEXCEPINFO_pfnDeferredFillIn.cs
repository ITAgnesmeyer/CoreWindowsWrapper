using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///param0: tagEXCEPINFO*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int tagEXCEPINFO_pfnDeferredFillIn(ref tagEXCEPINFO param0);
}