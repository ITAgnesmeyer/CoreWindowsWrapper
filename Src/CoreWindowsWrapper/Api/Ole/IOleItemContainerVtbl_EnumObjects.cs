using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleItemContainer*
    ///grfFlags: DWORD->unsigned int
    ///ppenum: IEnumUnknown**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleItemContainerVtbl_EnumObjects(ref IOleItemContainer This, uint grfFlags,
        ref IntPtr ppenum);
}