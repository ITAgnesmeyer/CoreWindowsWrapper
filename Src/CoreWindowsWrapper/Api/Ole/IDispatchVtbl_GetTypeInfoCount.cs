using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IDispatch*
    ///pctinfo: UINT*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IDispatchVtbl_GetTypeInfoCount(ref IDispatch This, ref uint pctinfo);
}