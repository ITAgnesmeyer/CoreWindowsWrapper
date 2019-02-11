using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IDataObject*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IDataObjectVtbl_AddRef(ref IDataObject This);
}