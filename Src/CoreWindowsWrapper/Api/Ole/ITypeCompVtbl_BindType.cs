using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: ITypeComp*
    ///szName: LPOLESTR->OLECHAR*
    ///lHashVal: ULONG->unsigned int
    ///ppTInfo: ITypeInfo**
    ///ppTComp: ITypeComp**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int ITypeCompVtbl_BindType(ref ITypeComp This, IntPtr szName, uint lHashVal,
        ref IntPtr ppTInfo, ref IntPtr ppTComp);
}