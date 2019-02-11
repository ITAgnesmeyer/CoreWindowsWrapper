using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStorage*
    ///pwcsName: OLECHAR*
    ///pctime: FILETIME*
    ///patime: FILETIME*
    ///pmtime: FILETIME*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStorageVtbl_SetElementTimes(ref IStorage This,
        [In()]
        [MarshalAs(UnmanagedType.LPWStr)]
        string pwcsName, ref FILETIME pctime, ref FILETIME patime, ref FILETIME pmtime);
}