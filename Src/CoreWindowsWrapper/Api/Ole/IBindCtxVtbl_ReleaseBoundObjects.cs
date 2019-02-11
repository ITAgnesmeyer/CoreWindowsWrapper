using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IBindCtx*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IBindCtxVtbl_ReleaseBoundObjects(ref IBindCtx This);
}