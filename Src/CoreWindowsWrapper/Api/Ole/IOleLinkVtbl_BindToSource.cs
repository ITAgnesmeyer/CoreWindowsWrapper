using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleLink*
    ///bindflags: DWORD->unsigned int
    ///pbc: IBindCtx*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleLinkVtbl_BindToSource(ref IOleLink This, uint bindflags, ref IBindCtx pbc);
}