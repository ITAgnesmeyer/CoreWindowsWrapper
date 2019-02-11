using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IStorage*
    ///pwcsName: OLECHAR*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IStorageVtbl_DestroyElement(ref IStorage This,
        [In()]
        [MarshalAs(UnmanagedType.LPWStr)]
        string pwcsName);
}