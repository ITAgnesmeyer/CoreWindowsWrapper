using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeInfo*
    ///rgszNames: LPOLESTR*
    ///cNames: UINT->unsigned int
    ///pMemId: MEMBERID*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeInfoVtbl_GetIDsOfNames(ref ITypeInfo This, ref IntPtr rgszNames, uint cNames,
        ref int pMemId);
}