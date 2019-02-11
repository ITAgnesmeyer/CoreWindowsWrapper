using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeInfo*
    ///memid: MEMBERID->DISPID->LONG->int
    ///rgBstrNames: BSTR*
    ///cMaxNames: UINT->unsigned int
    ///pcNames: UINT*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeInfoVtbl_GetNames(ref ITypeInfo This, int memid,
        [MarshalAs(UnmanagedType.BStr)]
        ref string rgBstrNames, uint cMaxNames, ref uint pcNames);
}