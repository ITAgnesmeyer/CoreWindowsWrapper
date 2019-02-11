using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleObject*
    ///ppEnumOleVerb: IEnumOLEVERB**
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleObjectVtbl_EnumVerbs(ref IOleObject This, ref IntPtr ppEnumOleVerb);
}