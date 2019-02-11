using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeInfo*
    ///memid: MEMBERID->DISPID->LONG->int
    ///invKind: INVOKEKIND->tagINVOKEKIND
    ///ppv: PVOID*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeInfoVtbl_AddressOfMember(ref ITypeInfo This, int memid, tagINVOKEKIND invKind,
        ref IntPtr ppv);
}