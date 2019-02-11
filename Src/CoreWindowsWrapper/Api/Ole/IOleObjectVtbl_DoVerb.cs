using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleObject*
    ///iVerb: LONG->int
    ///lpmsg: LPMSG->tagMSG*
    ///pActiveSite: IOleClientSite*
    ///lindex: LONG->int
    ///hwndParent: HWND->HWND__*
    ///lprcPosRect: LPCRECT->RECT*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleObjectVtbl_DoVerb(ref IOleObject This, int iVerb, ref tagMSG lpmsg,
        ref IOleClientSite pActiveSite, int lindex, IntPtr hwndParent, ref tagRECT lprcPosRect);
}