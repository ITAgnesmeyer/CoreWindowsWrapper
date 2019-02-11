using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IPersistStorage*
    ///pStgSave: IStorage*
    ///fSameAsLoad: BOOL->int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IPersistStorageVtbl_Save(ref IPersistStorage This, ref IStorage pStgSave,
        [MarshalAs(UnmanagedType.Bool)]
        bool fSameAsLoad);
}