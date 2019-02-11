using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeInfo*
    ///memid: MEMBERID->DISPID->LONG->int
    ///pBstrMops: BSTR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeInfoVtbl_GetMops(ref ITypeInfo This, int memid,
        [MarshalAs(UnmanagedType.BStr)]
        ref string pBstrMops);
}