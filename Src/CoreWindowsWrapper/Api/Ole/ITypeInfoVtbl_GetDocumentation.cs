using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeInfo*
    ///memid: MEMBERID->DISPID->LONG->int
    ///pBstrName: BSTR*
    ///pBstrDocString: BSTR*
    ///pdwHelpContext: DWORD*
    ///pBstrHelpFile: BSTR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeInfoVtbl_GetDocumentation(ref ITypeInfo This, int memid,
        [MarshalAs(UnmanagedType.BStr)]
        ref string pBstrName,
        [MarshalAs(UnmanagedType.BStr)]
        ref string pBstrDocString, ref uint pdwHelpContext,
        [MarshalAs(UnmanagedType.BStr)]
        ref string pBstrHelpFile);
}