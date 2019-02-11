using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IMoniker*
    ///pmkOther: IMoniker*
    ///ppmkRelPath: IMoniker**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IMonikerVtbl_RelativePathTo(ref IMoniker This, ref IMoniker pmkOther,
        ref IntPtr ppmkRelPath);
}