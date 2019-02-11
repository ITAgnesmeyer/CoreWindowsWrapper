using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleCache2*
    ///pDataObject: IDataObject*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleCache2Vtbl_InitCache(ref IOleCache2 This, ref IDataObject pDataObject);
}