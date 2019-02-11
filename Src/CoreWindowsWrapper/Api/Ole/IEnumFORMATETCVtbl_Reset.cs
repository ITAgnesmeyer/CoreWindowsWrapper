using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IEnumFORMATETC*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IEnumFORMATETCVtbl_Reset(ref IEnumFORMATETC This);
}