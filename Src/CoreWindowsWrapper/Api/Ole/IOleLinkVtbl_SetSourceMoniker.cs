using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleLink*
    ///pmk: IMoniker*
    ///rclsid: IID*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleLinkVtbl_SetSourceMoniker(ref IOleLink This, ref IMoniker pmk, ref GUID rclsid);
}