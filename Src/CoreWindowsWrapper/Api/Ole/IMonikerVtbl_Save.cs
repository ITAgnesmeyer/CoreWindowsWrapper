using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IMoniker*
    ///pStm: IStream*
    ///fClearDirty: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IMonikerVtbl_Save(ref IMoniker This, ref IStream pStm,
        [MarshalAs(UnmanagedType.Bool)]
        bool fClearDirty);
}