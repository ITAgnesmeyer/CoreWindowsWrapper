using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeComp*
    ///szName: LPOLESTR->OLECHAR*
    ///lHashVal: ULONG->unsigned int
    ///wFlags: WORD->unsigned short
    ///ppTInfo: ITypeInfo**
    ///pDescKind: DESCKIND*
    ///pBindPtr: BINDPTR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeCompVtbl_Bind(ref ITypeComp This, IntPtr szName, uint lHashVal, ushort wFlags,
        ref IntPtr ppTInfo, ref tagDESCKIND pDescKind, ref tagBINDPTR pBindPtr);
}