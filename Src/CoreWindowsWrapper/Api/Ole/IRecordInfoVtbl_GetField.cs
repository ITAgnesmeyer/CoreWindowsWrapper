using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRecordInfo*
    ///pvData: PVOID->void*
    ///szFieldName: LPCOLESTR->OLECHAR*
    ///pvarField: VARIANT*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRecordInfoVtbl_GetField(ref IRecordInfo This, IntPtr pvData,
        [In()]
        [MarshalAs(UnmanagedType.LPWStr)]
        string szFieldName, ref tagVARIANT pvarField);
}