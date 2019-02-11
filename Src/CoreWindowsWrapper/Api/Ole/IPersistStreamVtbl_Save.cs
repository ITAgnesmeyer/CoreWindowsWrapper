using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IPersistStream*
    ///pStm: IStream*
    ///fClearDirty: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IPersistStreamVtbl_Save(ref IPersistStream This, ref IStream pStm,
        [MarshalAs(UnmanagedType.Bool)]
        bool fClearDirty);
}