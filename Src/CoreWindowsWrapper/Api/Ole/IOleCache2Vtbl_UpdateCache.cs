using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleCache2*
    ///pDataObject: LPDATAOBJECT->IDataObject*
    ///grfUpdf: DWORD->unsigned int
    ///pReserved: LPVOID->void*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleCache2Vtbl_UpdateCache(ref IOleCache2 This, ref IDataObject pDataObject, uint grfUpdf,
        IntPtr pReserved);
}