using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IDataObject*
    ///dwConnection: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IDataObjectVtbl_DUnadvise(ref IDataObject This, uint dwConnection);
}