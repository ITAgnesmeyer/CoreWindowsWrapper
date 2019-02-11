using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleAdviseHolder*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleAdviseHolderVtbl_SendOnSave(ref IOleAdviseHolder This);
}