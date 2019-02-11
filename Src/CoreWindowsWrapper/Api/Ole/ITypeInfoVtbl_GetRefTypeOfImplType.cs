using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeInfo*
    ///index: UINT->unsigned int
    ///pRefType: HREFTYPE*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeInfoVtbl_GetRefTypeOfImplType(ref ITypeInfo This, uint index, ref uint pRefType);
}