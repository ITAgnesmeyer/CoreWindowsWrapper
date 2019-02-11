using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IEnumMoniker*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IEnumMonikerVtbl_AddRef(ref IEnumMoniker This);
}