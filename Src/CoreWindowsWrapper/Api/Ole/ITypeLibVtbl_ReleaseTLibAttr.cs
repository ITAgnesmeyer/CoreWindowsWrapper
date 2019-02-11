using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: void
    ///This: ITypeLib*
    ///pTLibAttr: TLIBATTR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate void ITypeLibVtbl_ReleaseTLibAttr(ref ITypeLib This, ref tagTLIBATTR pTLibAttr);
}