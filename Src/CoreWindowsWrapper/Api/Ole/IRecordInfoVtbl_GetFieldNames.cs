using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRecordInfo*
    ///pcNames: ULONG*
    ///rgBstrNames: BSTR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRecordInfoVtbl_GetFieldNames(ref IRecordInfo This, ref uint pcNames,
        [MarshalAs(UnmanagedType.BStr)]
        ref string rgBstrNames);
}