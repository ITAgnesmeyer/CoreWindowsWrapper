using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeLib*
    ///index: INT->int
    ///pBstrName: BSTR*
    ///pBstrDocString: BSTR*
    ///pdwHelpContext: DWORD*
    ///pBstrHelpFile: BSTR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeLibVtbl_GetDocumentation(ref ITypeLib This, int index,
        [MarshalAs(UnmanagedType.BStr)]
        ref string pBstrName,
        [MarshalAs(UnmanagedType.BStr)]
        ref string pBstrDocString, ref uint pdwHelpContext,
        [MarshalAs(UnmanagedType.BStr)]
        ref string pBstrHelpFile);
}