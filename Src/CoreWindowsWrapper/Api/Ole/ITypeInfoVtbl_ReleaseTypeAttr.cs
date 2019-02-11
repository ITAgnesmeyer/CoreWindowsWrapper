using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: void
    ///This: ITypeInfo*
    ///pTypeAttr: TYPEATTR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate void ITypeInfoVtbl_ReleaseTypeAttr(ref ITypeInfo This, ref tagTYPEATTR pTypeAttr);
}