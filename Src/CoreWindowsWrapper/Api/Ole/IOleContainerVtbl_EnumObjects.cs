using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleContainer*
    ///grfFlags: DWORD->unsigned int
    ///ppenum: IEnumUnknown**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleContainerVtbl_EnumObjects(ref IOleContainer This, uint grfFlags, ref IntPtr ppenum);
}