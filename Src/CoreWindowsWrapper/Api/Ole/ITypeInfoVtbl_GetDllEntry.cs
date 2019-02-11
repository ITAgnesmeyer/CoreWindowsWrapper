using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeInfo*
    ///memid: MEMBERID->DISPID->LONG->int
    ///invKind: INVOKEKIND->tagINVOKEKIND
    ///pBstrDllName: BSTR*
    ///pBstrName: BSTR*
    ///pwOrdinal: WORD*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeInfoVtbl_GetDllEntry(ref ITypeInfo This, int memid, tagINVOKEKIND invKind,
        [MarshalAs(UnmanagedType.BStr)]
        ref string pBstrDllName,
        [MarshalAs(UnmanagedType.BStr)]
        ref string pBstrName, ref ushort pwOrdinal);
}