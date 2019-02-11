using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IBindCtx*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IBindCtxVtbl_AddRef(ref IBindCtx This);
}