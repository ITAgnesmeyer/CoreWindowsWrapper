using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRecordInfo*
    ///pbstrName: BSTR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRecordInfoVtbl_GetName(ref IRecordInfo This,
        [MarshalAs(UnmanagedType.BStr)]
        ref string pbstrName);
}