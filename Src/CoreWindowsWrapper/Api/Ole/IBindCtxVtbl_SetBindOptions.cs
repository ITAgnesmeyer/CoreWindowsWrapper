using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IBindCtx*
    ///pbindopts: BIND_OPTS*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IBindCtxVtbl_SetBindOptions(ref IBindCtx This, ref tagBIND_OPTS pbindopts);
}