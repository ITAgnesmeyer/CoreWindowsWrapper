using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeLib*
    ///index: UINT->unsigned int
    ///pTKind: TYPEKIND*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeLibVtbl_GetTypeInfoType(ref ITypeLib This, uint index, ref tagTYPEKIND pTKind);
}