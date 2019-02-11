using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IMoniker*
    ///pmkRight: IMoniker*
    ///fOnlyIfNotGeneric: BOOL->int
    ///ppmkComposite: IMoniker**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IMonikerVtbl_ComposeWith(ref IMoniker This, ref IMoniker pmkRight,
        [MarshalAs(UnmanagedType.Bool)]
        bool fOnlyIfNotGeneric, ref IntPtr ppmkComposite);
}