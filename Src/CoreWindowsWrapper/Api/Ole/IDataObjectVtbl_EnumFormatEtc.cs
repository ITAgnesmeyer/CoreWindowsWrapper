using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IDataObject*
    ///dwDirection: DWORD->unsigned int
    ///ppenumFormatEtc: IEnumFORMATETC**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IDataObjectVtbl_EnumFormatEtc(ref IDataObject This, uint dwDirection,
        ref IntPtr ppenumFormatEtc);
}