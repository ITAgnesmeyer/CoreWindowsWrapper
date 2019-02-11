using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IRunningObjectTable*
    ///grfFlags: DWORD->unsigned int
    ///punkObject: IUnknown*
    ///pmkObjectName: IMoniker*
    ///pdwRegister: DWORD*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IRunningObjectTableVtbl_Register(ref IRunningObjectTable This, uint grfFlags,
        ref IUnknown punkObject, ref IMoniker pmkObjectName, ref uint pdwRegister);
}