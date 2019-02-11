using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IDispatch*
    ///dispIdMember: DISPID->LONG->int
    ///riid: IID*
    ///lcid: LCID->DWORD->unsigned int
    ///wFlags: WORD->unsigned short
    ///pDispParams: DISPPARAMS*
    ///pVarResult: VARIANT*
    ///pExcepInfo: EXCEPINFO*
    ///puArgErr: UINT*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IDispatchVtbl_Invoke(ref IDispatch This, int dispIdMember, ref GUID riid, uint lcid,
        ushort wFlags, ref tagDISPPARAMS pDispParams, ref tagVARIANT pVarResult, ref tagEXCEPINFO pExcepInfo,
        ref uint puArgErr);
}