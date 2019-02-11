using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleObject*
    ///pDataObject: IDataObject*
    ///fCreation: BOOL->int
    ///dwReserved: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleObjectVtbl_InitFromData(ref IOleObject This, ref IDataObject pDataObject,
        [MarshalAs(UnmanagedType.Bool)]
        bool fCreation, uint dwReserved);
}