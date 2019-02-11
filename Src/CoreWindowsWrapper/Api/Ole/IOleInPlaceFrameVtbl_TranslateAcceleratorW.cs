using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceFrame*
    ///lpmsg: LPMSG->tagMSG*
    ///wID: WORD->unsigned short
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceFrameVtbl_TranslateAcceleratorW(ref IOleInPlaceFrame This, ref tagMSG lpmsg,
        ushort wID);
}