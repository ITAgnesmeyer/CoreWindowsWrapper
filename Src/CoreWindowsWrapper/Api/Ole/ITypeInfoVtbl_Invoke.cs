using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeInfo*
    ///pvInstance: PVOID->void*
    ///memid: MEMBERID->DISPID->LONG->int
    ///wFlags: WORD->unsigned short
    ///pDispParams: DISPPARAMS*
    ///pVarResult: VARIANT*
    ///pExcepInfo: EXCEPINFO*
    ///puArgErr: UINT*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeInfoVtbl_Invoke(ref ITypeInfo This, IntPtr pvInstance, int memid, ushort wFlags,
        ref tagDISPPARAMS pDispParams, ref tagVARIANT pVarResult, ref tagEXCEPINFO pExcepInfo, ref uint puArgErr);
}