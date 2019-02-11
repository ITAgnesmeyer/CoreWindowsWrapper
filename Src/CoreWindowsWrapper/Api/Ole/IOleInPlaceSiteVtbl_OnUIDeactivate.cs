using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceSite*
    ///fUndoable: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceSiteVtbl_OnUIDeactivate(ref IOleInPlaceSite This,
        [MarshalAs(UnmanagedType.Bool)]
        bool fUndoable);
}