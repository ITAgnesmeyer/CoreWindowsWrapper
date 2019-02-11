using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleCache*
    ///pDataObject: IDataObject*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleCacheVtbl_InitCache(ref IOleCache This, ref IDataObject pDataObject);
}