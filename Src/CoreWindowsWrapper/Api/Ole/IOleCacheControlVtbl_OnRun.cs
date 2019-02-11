using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleCacheControl*
    ///pDataObject: LPDATAOBJECT->IDataObject*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleCacheControlVtbl_OnRun(ref IOleCacheControl This, ref IDataObject pDataObject);
}